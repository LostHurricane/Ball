using UnityEngine;

namespace GeekProject
{
    public class CameraController : ILateExecute
    {
        private Transform target;
        Camera myCamera;
        private Vector3 offsetPosition ;
        private Space offsetPositionSpace;//= Space.Self;
        private bool lookAt;// = true;

        public CameraController(Transform target, Vector3 offset, Space space, bool lookAt)
        {
            myCamera = Camera.main;
            offsetPosition = offset;
            offsetPositionSpace = space;
            this.lookAt = lookAt;
            this.target = target;
        }

        public void LateExecute(float deltaTime)
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
    }
}