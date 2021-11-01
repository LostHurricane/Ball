using System;
using UnityEngine;

namespace GeekProject
{
    public class PCInputKeyDown : IUserInputKey
    {
        private KeyCode _key;
        public PCInputKeyDown(KeyCode key)
        {
            _key = key;
        }

        public event Action<bool> KeyPressed = delegate (bool b) { };

        public void GetKey()
        {
            KeyPressed.Invoke(Input.GetKeyDown(_key));
        }
    }
}