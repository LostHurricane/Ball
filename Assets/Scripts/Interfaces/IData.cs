using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public interface IData<T>
    {
        void Save(T Data, string path);

        T Load(string path = null);
    }
}