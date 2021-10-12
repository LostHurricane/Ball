using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    [CreateAssetMenu(fileName = "DataBonuses", menuName = "ScriptableObjects/DataBonuses")]

    public class DataBonuses : ScriptableObject
    {
        [SerializeField]
        private BonusCollectable bonusPrefab;
        public BonusCollectable GetBonus()
        {
            return bonusPrefab;
        }
    }
}