using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeekProject;

public class Trap_Jump : MonoBehaviour, IInteractible
{

    [SerializeField]
    private float VerticalPower = 3f;
    [SerializeField]
    private float HorisontalPower = 3f;

    public bool IsActive { get; } = true;

    public void Activate()
    {
        Debug.Log("Jump!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            Activate();
            other.attachedRigidbody.AddForce((other.transform.position - transform.position) * HorisontalPower + Vector3.up * VerticalPower, ForceMode.Impulse);
        }
    }
       

}
