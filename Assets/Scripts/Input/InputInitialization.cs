using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public sealed class InputInitialization : IInitialization
    {

        private IUserInputAxisProxy _pcInputHorizontal;
        private IUserInputAxisProxy _pcInputVertical;

        public void Initialization()
        { }

        public InputInitialization()
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();
        }

        public (IUserInputAxisProxy inputHorizontal, IUserInputAxisProxy inputVertical) GetInput()
        {
            (IUserInputAxisProxy inputHorizontal, IUserInputAxisProxy inputVertical) result = (_pcInputHorizontal, _pcInputVertical);
            return result;
        }
    }
}