using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GeekProject;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 offsetPosition;
    [SerializeField]
    private Space offsetPositionSpace = Space.Self;
    [SerializeField]
    private bool lookAt = true;
    private CameraController myCamera;

    [SerializeField]
    private Data data;

    private Controllers controllers;

    private void Start()
    {
        controllers = new Controllers();
        new GameInitialisaton(controllers, data, GameObject.Find("Player").transform, GameObject.Find("Labirinth").transform);

        //target = transform;
        if (target == null) throw new InvalidDataException("Не видно, что давать камере");
        
        myCamera = new CameraController(target, offsetPosition, offsetPositionSpace, lookAt);
        
    }

    // Update is called once per frame
    void Update()
    {
        controllers.Execute(Time.deltaTime);


    }

    private void LateUpdate()
    {
        controllers.LateExecute(Time.deltaTime);
        myCamera.LateExecute(Time.deltaTime);

    }

    private void OnDestroy()
    {
        controllers.Cleanup();
    }


}
