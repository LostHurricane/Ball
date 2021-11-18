using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class LevelRotator : ILateExecute, ICleanup
    {
        private float _inputHorizontal;
        private float _inputVertical;

        private int _turningSpeed = 20;

        private float _rotX = 0.0f; // rotation around the right/x axis
        private float _rotY = 0.0f; // rotation around the up/y axis

        private IUserInputAxisProxy _horizontalInputProxy;
        private IUserInputAxisProxy _verticalInputProxy;

        private Transform _level;



        public LevelRotator((IUserInputAxisProxy _inputHorizontal, IUserInputAxisProxy _inputVertical) input/*, Transform _level*/)
        {
            
            _level = GameObject.Find("Labirinth").transform;

            _horizontalInputProxy = input._inputHorizontal;
            _verticalInputProxy = input._inputVertical;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisOnChange;
        }

        private void VerticalOnAxisOnChange(float value)
        {
            _inputVertical = value;
            //Debug.Log(value);
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _inputHorizontal = value;
            //Debug.Log(value);
        }

        public void LateExecute(float time)
        {
            _rotY = _turningSpeed * (_inputHorizontal) * time;
            _rotX = _turningSpeed * (_inputVertical) * time;

            _level.Rotate(_rotX, 0f, _rotY);

        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange -= VerticalOnAxisOnChange;
        }

    }
}