using System;
using UnityEngine;

namespace GeekProject
{
    public class PCInputHorizontal : IUserInputAxisProxy
    {
        public event Action<float> AxisOnChange = delegate (float i) { };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis("Horizontal"));

        }
    }
}