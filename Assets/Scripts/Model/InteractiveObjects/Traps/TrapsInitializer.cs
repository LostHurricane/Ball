using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public class TrapsInitializer
    {
        private TrapGenerator trapGenerator;

        public TrapsInitializer(DataTraps dataTraps)
        {
            trapGenerator = new TrapGenerator(dataTraps);
        }

        public void GetTraps (Vector3[] coordinates, Transform Layer)
        {
            foreach (Vector3 place in coordinates)
            {
                trapGenerator.Create(place, Layer);
            }
        }

    }
}