using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class TrapAnBonusCoordinatesDestributor
    {
        private TrapAndBonusesDataBase trapsAndBonusesLocationData;


        private float trapToBonusRatio;
        //private Vector3[] allCoordinates;
        private List<Vector3> allCoordinates;

        private int trapsAmount;
        private int bonusesAmount;

        public List<Vector3> TrapsLocation { get; private set; }
        public List<Vector3> BonusesLocation { get; private set; }

        public TrapAnBonusCoordinatesDestributor(TrapAndBonusesDataBase data)
        {
            trapsAndBonusesLocationData = data;
            allCoordinates = new List<Vector3>(trapsAndBonusesLocationData.GetCoordinates());
            //allCoordinates.AddRange(trapsAndBonusesLocationData.GetCoordinates());
            trapToBonusRatio = trapsAndBonusesLocationData.GetTrapBonusRate();
            bonusesAmount = (int)(allCoordinates.Count / (trapsAndBonusesLocationData.GetTrapBonusRate() + 1));
            trapsAmount = allCoordinates.Count - bonusesAmount;

            TrapAndBonusDistribution();
        }

        public void TrapAndBonusDistribution()
        {
            TrapsLocation = new List<Vector3>(trapsAmount);
            BonusesLocation = new List<Vector3>(bonusesAmount);
            while (trapsAmount > 0)
            {
                //Debug.Log(trapsAmount);
                
                var i = Random.Range(0, allCoordinates.Count);
                TrapsLocation.Add(allCoordinates[i]);
                allCoordinates.RemoveAt(i);
                trapsAmount--;
            }
            BonusesLocation = allCoordinates;
        }
        

    }
}