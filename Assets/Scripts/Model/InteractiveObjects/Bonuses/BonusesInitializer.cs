using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class BonusesInitializer
    {
        private BonusGenerator bonusGenerator;

        public BonusesInitializer(DataBonuses dataBonuses)
        {
            bonusGenerator = new BonusGenerator(dataBonuses);
        }

        public void GetBonuses(Vector3[] coordinates, Transform Layer)
        {
            foreach (Vector3 place in coordinates)
            {
                bonusGenerator.Create(place, Layer);
            }
        }
    }
}