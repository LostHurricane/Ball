using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class TrapAndBonusInitializer
    {
        private TrapAnBonusCoordinatesDestributor coordinatesDealer;
        private Transform trapLayer;
        private Transform bonusLayer;

        public TrapAndBonusInitializer (Data data)
        {
            //this.data = data;
            trapLayer = GameObject.Find("Traps").transform;
            bonusLayer = GameObject.Find("Bonuses").transform;

            coordinatesDealer = new TrapAnBonusCoordinatesDestributor(data.GetTrapsAndBonuses());
            new TrapsInitializer(data.GetTrapsData()).GetTraps(coordinatesDealer.TrapsLocation.ToArray(), trapLayer);
            new BonusesInitializer(data.GetBonusData()).GetBonuses(coordinatesDealer.BonusesLocation.ToArray(), bonusLayer);
    
        }

    }
}