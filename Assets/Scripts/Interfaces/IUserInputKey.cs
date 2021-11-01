using System;

namespace GeekProject
{
    public interface IUserInputKey
    {
        event Action<bool> KeyPressed;
        void GetKey();
    }
}