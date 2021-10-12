using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    [CreateAssetMenu(fileName = "DataTraps", menuName = "ScriptableObjects/DataTraps")]
    public class DataTraps : ScriptableObject
    {
        [SerializeField] private TrapJump trapPrefab;

        [SerializeField] private float _verticalPower;
        public float VerticalPower { get => _verticalPower; }

        [SerializeField] private float _horisontalPower;
        public float HorisontalPower { get => _horisontalPower; }



        public TrapJump GetTrap ()
        {
            return trapPrefab;
        }


    }
}