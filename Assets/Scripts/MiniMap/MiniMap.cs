using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class MiniMap : MonoBehaviour, ILateExecute
    {
        [SerializeField] private Transform _level;
        private void Start()
        {
            var main = Camera.main;
            //_level = main.transform;
            transform.parent = null;
            transform.position = _level.position + new Vector3(80f, 30f, 65f);
            transform.LookAt(_level.position);//Quaternion.Euler(30.0f, 0, 0);

            var rt = Resources.Load<RenderTexture>("MiniMap/MiniMapTexture");

            var component = GetComponent<Camera>();
            component.targetTexture = rt;
            component.depth = --main.depth;
        }

        public void LateExecute(float deltaTime)
        {
            //var newPosition = _level.position;
            //newPosition.y = transform.position.y;
            //transform.position = newPosition;
            //transform.rotation = Quaternion.Euler(90, _level.eulerAngles.y, 0);
        }
    }
}