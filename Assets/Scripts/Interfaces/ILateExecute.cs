namespace GeekProject
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }
}