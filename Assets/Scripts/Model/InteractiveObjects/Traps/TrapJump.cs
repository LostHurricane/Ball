using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GeekProject
{
    public class TrapJump : MonoBehaviour, IInteractible
    {

        [SerializeField]
        private float VerticalPower;
        [SerializeField]
        private float HorisontalPower;

        public event System.Action<int> Effect; //Obobshenniy Delegate

        public bool IsActive { get; } = true;

       public TrapJump()
        {
            VerticalPower = 3f;
            HorisontalPower = 3f;
        }

        public void SetPowers(float VPover, float HPover)
        {
            VerticalPower = VPover;
            HorisontalPower = HPover;
        }

        public void Activate()
        {
            Debug.Log("Jump!");
            Effect?.Invoke(UnityEngine.Random.Range(-3, 0));
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Activate();
                other.attachedRigidbody.AddForce((other.transform.position - transform.position) * HorisontalPower + Vector3.up * VerticalPower, ForceMode.Impulse);
            }
        }


    }
}