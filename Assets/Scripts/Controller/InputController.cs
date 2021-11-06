using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class InputController : IExecute
    {
        //private SaveDataRepository _saveDataRepository;
        //private Vector3[] _traps;
        //private Vector3[] _bonuses;




        private readonly IUserInputAxisProxy _horizontal;
        private readonly IUserInputAxisProxy _vertical;

        private IUserInputKey _pcInputSave;
        private IUserInputKey _pcInputLoad;

        
        
        public InputController((IUserInputAxisProxy inputHorizontal, IUserInputAxisProxy inputVertical) inputMovement, (IUserInputKey inputSave, IUserInputKey inputLoad) inputSaves)
        {
            _horizontal = inputMovement.inputHorizontal;
            _vertical = inputMovement.inputVertical;

            _pcInputSave = inputSaves.inputSave;
            _pcInputLoad = inputSaves.inputLoad;

        }

      
        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();

            _pcInputSave.GetKey();
            _pcInputLoad.GetKey();

        }


        //void SaveGame(bool b)
        //{
        //    if (b)
        //        _saveDataRepository.Save();

        //}
    }
}