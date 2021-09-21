using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeekProject;

public class BonusCollectable : MonoBehaviour, IInteractible
{
    public int value { get; }

    public bool IsActive { get; private set; } = true;

    public void Activate()
    {
        IsActive = false;
        Debug.Log("Bonus!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && IsActive)
        {
            Activate();
        }
    }
}
