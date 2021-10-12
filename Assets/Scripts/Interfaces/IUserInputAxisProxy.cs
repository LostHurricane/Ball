using System;

namespace GeekProject
{
    public interface IUserInputAxisProxy
    {
        event Action<float> AxisOnChange;
        void GetAxis();
    }
}