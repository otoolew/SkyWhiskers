using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Aeroplane
{
    [RequireComponent(typeof (AeroplaneController))]
    public class AeroplaneUserControl2Axis : MonoBehaviour
    {
        float roll = 0f;
        float pitch = 0f;
        float airBrakes = 0f;
        float throttle = 0f;

        private AeroplaneController m_Aeroplane;

        private void Awake()
        {
            // Set up the reference to the aeroplane controller.
            m_Aeroplane = GetComponent<AeroplaneController>();
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
            m_Aeroplane.Move(roll, pitch, 0, throttle, airBrakes);
        }
        private void FixedUpdate()
        {
            Fly();
        }
    }
}
