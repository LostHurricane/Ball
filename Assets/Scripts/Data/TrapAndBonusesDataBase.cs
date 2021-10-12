using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GeekProject
{
    [CreateAssetMenu(fileName = "TrapAndBonusesDataBase", menuName = "ScriptableObjects/TrapAndBonusesDataBase")]
    public class TrapAndBonusesDataBase : ScriptableObject
    {
        [SerializeField]
        private Vector3[] interactiveObjectsCoordinats;

        [SerializeField]
        [Range (0f, 2f)]
        private float trapToBonusRatio;


        public Vector3[] GetCoordinates()
        {
            return interactiveObjectsCoordinats;
        }

        public float GetTrapBonusRate()
        {
            return trapToBonusRatio;
        }

    }

    
}