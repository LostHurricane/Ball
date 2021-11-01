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
        private Vector3[] _traps;
        private Vector3[] _bonuses;

        LevelRotator lr;

        public SaveLoadManager((IUserInputKey inputSave, IUserInputKey inputLoad) input, Transform player, Transform level, (Vector3[] traps, Vector3[] bonuses) coordinates, LevelRotator levelRotator)
        {
            _saveButton = input.inputSave;
            _loadButton = input.inputLoad;
            
            _saveButton.KeyPressed += SaveKey;
            _loadButton.KeyPressed += LoadKey;

            _traps = coordinates.traps;
            _bonuses = coordinates.bonuses;
            _player = player;
            _level = level;

            _saveDataRepository = new SaveDataRepository(/*_traps, _bonuses*/);

            lr = levelRotator;
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
                
                Debug.Log("Load");
                _saveDataRepository.Load(_player, _level);
                lr.RotationChanged();
                Debug.Log(_level.rotation.eulerAngles.ToString());

                //temp = _level.rotation.eulerAngles;
               

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
