using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class BonusCollectable : MonoBehaviour, IInteractible
    {
        public int Value { get; private set; }

        public bool IsActive { get; private set; } = true;

        //public delegate void (int bonus); //My delegate
        public event Action<int> Effect; //Obobshenniy Delegate

        private void Start ()
        {
            Value = UnityEngine.Random.Range(1, 5);
            Debug.Log("Bonus " + gameObject.name + " Value: " + Value);
        }

        public void Activate()
        {
            IsActive = false;

            Effect?.Invoke(Value);
            Debug.Log("Bonus: " + Value);
            Destroy(gameObject, 0.3f);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && IsActive)
            {
                Activate();
            }
        }
    }
}