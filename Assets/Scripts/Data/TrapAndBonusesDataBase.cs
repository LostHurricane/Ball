using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GeekProject
{
    [CreateAssetMenu(fileName = "TrapAndBonusesDataBase", menuName = "ScriptableObjects/TrapAndBonusesDataBase")]
    public class TrapAndBonusesDataBase : ScriptableObject
    {
        [SerializeField]
        //private Vector3[] interactiveObjectsCoordinats;
        List <Vector3> _interactiveObjectsCoordinats;

        [SerializeField]
        [Range (0f, 2f)]
        private float _trapToBonusRatio;

        [SerializeField]
        private CoordinatePoint _coordinatePoint;

        public Vector3[] GetCoordinates()
        {
            return _interactiveObjectsCoordinats.ToArray();
        }

        public float GetTrapBonusRate()
        {
            return _trapToBonusRatio;
        }

        public void AddPoint(Vector3 coordinates)
        {
            _interactiveObjectsCoordinats.Add( coordinates);
        }

        public CoordinatePoint GetCoordinatePoint()
        {
            return _coordinatePoint;
        }

    }

    
}