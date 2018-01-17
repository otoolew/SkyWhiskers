using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AirplaneController))]
public class AirplaneControlBehavior : MonoBehaviour {
    float roll = 0f;
    float pitch = 0f;
    float airBrakes = 0f;
    float throttle = 0f;

    private AirplaneController _airplane;

    private void Awake()
    {
        // Set up the reference to the aeroplane controller.
        _airplane = GetComponent<AirplaneController>();
    }

    private void Update()
    {
        roll = Input.GetAxis("Mouse X");
        pitch = Input.GetAxis("Mouse Y");
        airBrakes = Input.GetAxis("LeftTrigger");
        throttle = Input.GetAxis("RightTrigger");
    }
    private void Fly()
    {
        _airplane.Move(roll, pitch, 0, throttle, airBrakes);
    }
    private void FixedUpdate()
    {
        Fly();
    }
}

