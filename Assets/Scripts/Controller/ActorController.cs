using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public class ActorController : MonoBehaviour
{
    private Animator animator;                              // Reference to the animator component.
    private Rigidbody playerRigidbody;                      // Reference to the player's rigidbody.
    private Vector3 movementInput;                          // The vector to store the direction of the player's movement.
    public float movementSpeed = 0f;                        // The speed that the player will move at.
    private Vector3 movementVelocity;

    int terrainMask;                                        // A layer mask so that a ray can be cast just at gameobjects on the floor layer.
    float camRayLength = 100f;                              // The length of the ray from the camera into the scene.
   
    public LayerMask layerMask;
    private bool moving = false;
    public bool controlsDisabled = false;
    public bool controllerSupport;
    void Awake()
    {
        // Create a layer mask for the floor layer.
        terrainMask = LayerMask.GetMask("Terrain");

        // Set up references.
        animator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (controlsDisabled)
            return;

        float hortinput = Input.GetAxisRaw("Horizontal");
        float vertinput = Input.GetAxisRaw("Vertical");


        movementInput = new Vector3(hortinput, 0f, vertinput);
        movementVelocity = movementInput * movementSpeed;
        Animating(hortinput, vertinput);
        if (!controllerSupport)
        {
            Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;
            if (Physics.Raycast(rayCast, out rayHit, 50f, layerMask))
            {
                Vector3 pointToLook = rayHit.point;
                transform.LookAt(pointToLook);
                //Debug.DrawLine(rayCast.origin, pointToLook, Color.blue);
            }
        }
        else
        {
            Debug.Log("Using Xbox Controller");
            Vector3 playerDirection = Vector3.right * Input.GetAxisRaw("RHorizontal") + Vector3.forward * -Input.GetAxisRaw("RVertical");
            //transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
            if (playerDirection.sqrMagnitude > 0.0f)
            {
                transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
            }
        }
        //float rayLength;
    }
    void FixedUpdate()
    {
        playerRigidbody.velocity = movementVelocity;
    }
    public void DisableControls()
    {
        controlsDisabled = true;
        playerRigidbody.isKinematic = true;
    }
    public void EnableControls()
    {
        controlsDisabled = false;
        playerRigidbody.isKinematic = false;
    }
    void Animating(float h, float v)
    {

        // Create a boolean that is true if either of the input axes is non-zero.
        bool walking = h != 0f || v != 0f;

        //animator.SetFloat("Movement", movementInput.z);
        // Tell the animator whether or not the player is walking.
        animator.SetBool("Moving", walking);
    }
}
