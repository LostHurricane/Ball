using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class InputController : IExecute
    {
        private readonly IUserInputAxisProxy _horizontal;
        private readonly IUserInputAxisProxy _vertical;

        public InputController((IUserInputAxisProxy inputHorizontal, IUserInputAxisProxy inputVertical) input)
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
        }

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            
            _vertical.GetAxis();
        }
    }
}