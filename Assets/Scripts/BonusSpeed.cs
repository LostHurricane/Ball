using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeekProject;

public class BonusSpeed : MonoBehaviour, IInteractible
{
    [SerializeField]
    private float Effectivnes = 0f;

    public bool IsActive { get; private set; } = false;


    public void Activate()
    {
        IsActive = true;
        Debug.Log("Bonus!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Activate();
        }
    }
}
