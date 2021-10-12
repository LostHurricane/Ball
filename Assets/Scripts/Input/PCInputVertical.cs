using System;
using UnityEngine;

namespace GeekProject
{
    public class PCInputVertical : IUserInputAxisProxy
    {
        public event Action<float> AxisOnChange = delegate (float i) { };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis("Vertical"));

        }
    }
}