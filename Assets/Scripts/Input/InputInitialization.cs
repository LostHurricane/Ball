using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public sealed class InputInitialization : IInitialization
    {

        private IUserInputAxisProxy _pcInputHorizontal;
        private IUserInputAxisProxy _pcInputVertical;
        private IUserInputKey _pcInputSave;
        private IUserInputKey _pcInputLoad;


        public void Initialization()
        { }

        public InputInitialization(InputData id)
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();

            _pcInputSave = new PCInputKeyDown(id.SaveGame);
            _pcInputLoad = new PCInputKeyDown(id.LoadGame);
        }

        public (IUserInputAxisProxy inputHorizontal, IUserInputAxisProxy inputVertical) GetInputMovement()
        {
            (IUserInputAxisProxy inputHorizontal, IUserInputAxisProxy inputVertical) result = (_pcInputHorizontal, _pcInputVertical);
            return result;
        }

        public (IUserInputKey inputSave, IUserInputKey inputLoad) GetInputDataSave()
        {
            (IUserInputKey inputSave, IUserInputKey inputLoad) result = (_pcInputSave, _pcInputLoad);
            return result;
        }
    }
}