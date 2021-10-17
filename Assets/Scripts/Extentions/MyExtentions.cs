using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace GeekProject
{
    public static class MyExtentions //: MonoBehaviour
    {
        /// <summary>
        /// Counts amount of times same set of simbols was in there
        /// </summary>
        /// <param name="str"></param>
        /// <param name="example"></param>
        /// <returns></returns>
        public static int FindParts (this string str, string example)
        {
            int counter = 1;
            for (var i = 0; i < (str.Length - 1 - (example.Length - 1)); i++)
            {
                if (str.Substring(i, example.Length).Contains(example))
                    counter++;
            }

            return counter;
        }

        /// <summary>
        /// Find and count each unique object in collection
        /// </summary>
        /// <typeparam name="T">что угодно</typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static Dictionary<T, int> CountAllUniques<T>(this ICollection<T> self)
        {
            var Uniques = new Dictionary<T, int>();
            foreach (T element in self)
            {
                if (!Uniques.ContainsKey(element))
                {
                    Uniques.Add(element, 1);
                }
                else
                    Uniques[element]++;
            }
            return Uniques;
        }

        /// <summary>
        /// Find and count each unique char in string
        /// </summary>
        /// <param name="self"></param>
        /// <returns>123</returns>
        public static Dictionary<char, int> CountAllUniques(this string self)
        {
            char[] str = self.ToCharArray();
            return str.CountAllUniques();
        }

        public static int CountExamples <T>(this ICollection<T> self, T example)
        {
            /*
            var j = from n in self
                    where n.Equals(example)
                    select n;
            */
            var j = self.Where(n => n.Equals(example));
            return j.Count();
        }
    }
}