using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private int directionInput;
        private int MoveInput;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            // pass the input to the car! - Copy
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");
            //float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            //m_Car.Move(h, v, v, handbrake);
            m_Car.Move(directionInput, MoveInput, MoveInput, 0f);

#else
            //m_Car.Move(directionInput, MoveInput, MoveInput, 0f);
#endif
        }

        public void Rotation(int InputAxis)
        {
            directionInput = InputAxis;
            Debug.Log(directionInput);
        }
        public void Move(int InputAxis)
        {
            MoveInput = InputAxis;
            Debug.Log(MoveInput);
        }
    }
}
