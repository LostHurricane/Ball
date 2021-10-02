using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GeekProject;

public class GameController : MonoBehaviour
{
    
    //private int collectedBonuses = 0;
    

    private PlayerProgressChecker playerProgressChecker;
    private BonusCollectable[] bonusesCollectable;
    private Trap_Jump[] traps;

    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 offsetPosition;
    [SerializeField]
    private Space offsetPositionSpace = Space.Self;
    [SerializeField]
    private bool lookAt = true;
    private CameraController myCamera;


    private void Awake()
    {
        //target = transform;
        if (target == null) throw new InvalidDataException("Не видно, что давать камере");
        
        myCamera = new CameraController(Camera.main, target, offsetPosition, offsetPositionSpace, lookAt);
        playerProgressChecker = new PlayerProgressChecker( 5 );

        bonusesCollectable = FindObjectsOfType<BonusCollectable>();
        foreach (BonusCollectable bc in bonusesCollectable)
        {
            bc.AddBonus += playerProgressChecker.BonusChanged;
        }

        traps = FindObjectsOfType<Trap_Jump>();
        foreach (Trap_Jump tr in traps)
        {
            tr.TakeBonus += playerProgressChecker.BonusChanged;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(target.transform.position);
        myCamera.CameraFollow(target);
    }


}
