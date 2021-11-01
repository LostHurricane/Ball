using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class LevelRotator : IExecute, ICleanup
    {
        private float inputMouseX;
        private float inputMouseY;

        private int turningSpeed = 20;

        private float rotX = 0.0f; // rotation around the right/x axis
        private float rotY = 0.0f; // rotation around the up/y axis
        private float maxAngle = 20;

        private IUserInputAxisProxy horizontalInputProxy;
        private IUserInputAxisProxy verticalInputProxy;

        private Transform level;



        public LevelRotator((IUserInputAxisProxy _inputHorizontal, IUserInputAxisProxy _inputVertical) input/*, Transform _level*/)
        {
            
            level = GameObject.Find("Labirinth").transform;

            horizontalInputProxy = input._inputHorizontal;
            verticalInputProxy = input._inputVertical;
            horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            verticalInputProxy.AxisOnChange += VerticalOnAxisOnChange;
        }

        private void VerticalOnAxisOnChange(float value)
        {
            inputMouseY = value;
            //Debug.Log(value);
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            inputMouseX = value;
            //Debug.Log(value);
        }

        public void Execute(float time)
        {
            rotY += turningSpeed * (inputMouseX) * time;
            rotX += turningSpeed * (inputMouseY) * time;

            rotY = Mathf.Clamp(rotY, -maxAngle, maxAngle);
            rotX = Mathf.Clamp(rotX, -maxAngle, maxAngle);

            level.rotation = Quaternion.Euler(rotX, 0f, rotY);

 
        }

        public void Cleanup()
        {
            horizontalInputProxy.AxisOnChange -= HorizontalOnAxisOnChange;
            verticalInputProxy.AxisOnChange -= VerticalOnAxisOnChange;
        }

        public void RotationChanged()
        {
           
            rotX = level.rotation.eulerAngles.x;
            rotY = level.rotation.eulerAngles.z;

            //level.rotation = Quaternion.Euler(rotX, 0f, rotY);
        }

    }
}