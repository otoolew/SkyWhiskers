using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserFlightController : MonoBehaviour {
    float roll = 0f;
    float pitch = 0f;
    float airBrakes = 0f;
    float throttle = 0f;

    private AeroplaneController _aeroplane;

    private void Awake()
    {
        // Set up the reference to the aeroplane controller.
        _aeroplane = GetComponent<AeroplaneController>();
    }

    private void Update()
    {
        roll = Input.GetAxis("Horizontal");
        pitch = Input.GetAxis("Vertical");
        airBrakes = Input.GetAxis("LeftTrigger");
        throttle = Input.GetAxis("RightTrigger");
    }
    private void Fly()
    {
        _aeroplane.Move(roll, pitch, 0, throttle, airBrakes);
    }
    private void FixedUpdate()
    {
        Fly();
    }
}
