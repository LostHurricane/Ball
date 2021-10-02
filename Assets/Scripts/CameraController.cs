using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController //: MonoBehaviour
{
    private UnityEngine.Camera myCamera;
    //private Transform target;
    private Vector3 offsetPosition;
    private Space offsetPositionSpace;//= Space.Self;
    private bool lookAt;// = true;

    public CameraController(UnityEngine.Camera camera, Transform target, Vector3 offset, Space space, bool lookAt)
    {
        myCamera = camera;
        //this.target = target;
        offsetPosition = offset;
        offsetPositionSpace = space;
        this.lookAt = lookAt;
    }

    public void CameraFollow(Transform target)
    {
        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            myCamera.transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            myCamera.transform.position = target.position + offsetPosition;
        }

        // compute rotation
        if (lookAt)
        {
            myCamera.transform.LookAt(target);
        }
        else
        {
            myCamera.transform.rotation = target.rotation;
        }
    }

    public void CameraTremor(Camera camera)
    {

        //Debug.Log(null);
    }


}
