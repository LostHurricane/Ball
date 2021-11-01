using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GeekProject
{

    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data")]
    public class Data : ScriptableObject
    {
        [SerializeField] private string trapsAndBonusesLocation;
        private TrapAndBonusesDataBase trapsAndBonusesDataBase;

        [SerializeField] private string trapsInfoLocation;
        private DataTraps dataTraps;

        [SerializeField] private string bonusesInfoLocation;
        private DataBonuses dataBonuses;

        [SerializeField] private string inputDataLocation;
        private InputData inputData;



        public TrapAndBonusesDataBase GetTrapsAndBonuses ()
        {
            if (trapsAndBonusesDataBase == null)
            {
                trapsAndBonusesDataBase = Resources.Load<TrapAndBonusesDataBase>(Path.Combine( "Data/" + trapsAndBonusesLocation));
            }

            return trapsAndBonusesDataBase;
        }

        public DataTraps GetTrapsData()
        {
            if (dataTraps == null)
            {
                dataTraps = Resources.Load<DataTraps>(Path.Combine("Data/" + trapsInfoLocation));
            }

            return dataTraps;
        }

        public DataBonuses GetBonusData()
        {
            if (dataBonuses == null)
            {
                //Debug.Log("Loading");

                dataBonuses = Resources.Load<DataBonuses>(Path.Combine("Data/" + bonusesInfoLocation));
                //Debug.Log("Loaded");
            }

            return dataBonuses;
        }

        public InputData GetInputData()
        {
            if (inputData == null)
            {
                inputData = Resources.Load<InputData>(Path.Combine("Data/" + inputDataLocation));
            }

            return inputData;
        }


    }
}