using UnityEngine;

namespace GeekProject
{
    public interface IFactory
    {
        IInteractible Create(Vector3 position, Transform parent);
    }
}