using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace GeekProject
{
    public class Homework_7 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            /*
            List<int> jep = new List<int>();
            jep.Add(1);
            jep.Add(5);
            jep.Add(2);
            jep.Add(2);
            jep.Add(3);
            jep.Add(3);
            jep.Add(2);



            foreach (int n in jep)
                Debug.Log(n);
            var example = 5;
            Debug.Log(jep.CountExamples(example) + "of" + example);

                //string test = "1234 3434";
                //Debug.Log(test.FindParts("34"));
            */

            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4 },
                {"two",2 },
                { "one",1 },
                {"three",3 },
            };
            //var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; }); // Доманее задание исходная версия
            var d = dict.OrderBy(i => i.Value); // обращение к OrderBy с использованием лямбда-выражения =>
            foreach (var pair in d)
            {
                Debug.Log($"{pair.Key} - {pair.Value}");
            }

        }
    }
}