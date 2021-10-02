using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeekProject;

public class BonusCollectable : MonoBehaviour, IInteractible
{
    public int value { get; private set; } 

    public bool IsActive { get; private set; } = true;

    //public delegate void (int bonus); //My delegate
    public event Action<int> AddBonus; //Obobshenniy Delegate

       
    private void Awake()
    {
        value = UnityEngine.Random.Range(1, 5);
        Debug.Log("Bonus "+ gameObject.name +" Value: " + value);
       
    }

    public void Activate()
    {
        IsActive = false;
        
        AddBonus?.Invoke(value);
        Debug.Log("Bonus: " + value);
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
