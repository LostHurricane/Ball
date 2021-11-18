//using System;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class SaveLoadManager : IExecute, ICleanup
    {
        private IUserInputKey _saveButton;
        private IUserInputKey _loadButton;

        private bool _saveKeyPressed;
        private bool _loadKeyPressed;
        
        private SaveDataRepository _saveDataRepository;

        private Transform _player;
        private Transform _level;

        public SaveLoadManager((IUserInputKey inputSave, IUserInputKey inputLoad) input, Transform player, Transform level)
        {
            _saveButton = input.inputSave;
            _loadButton = input.inputLoad;
            
            _saveButton.KeyPressed += SaveKey;
            _loadButton.KeyPressed += LoadKey;

            _player = player;
            _level = level;

            _saveDataRepository = new SaveDataRepository();
        }

        public void Execute(float deltaTime)
        {
            if (_saveKeyPressed)
            {
                Debug.Log("Save" + _player.position);
                _saveDataRepository.Save(_player, _level);

            }

            if (_loadKeyPressed)
            {  
                _saveDataRepository.Load(_player, _level);
             }

        }

        private void SaveKey(bool pressed)
        {
            _saveKeyPressed = pressed;
           
        }

        private void LoadKey(bool pressed)
        {
            _loadKeyPressed = pressed;
           
        }

        public void Cleanup()
        {
            _saveButton.KeyPressed -= SaveKey;
            _loadButton.KeyPressed -= LoadKey;
        }

    }
}
