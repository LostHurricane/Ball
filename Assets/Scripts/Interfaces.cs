using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    /// <summary>
    /// Абстрактрый клас, наследуемый от монобеха
    /// </summary>
    //public abstract class InteractiveObject : MonoBehaviour, IActive
    //{
    //    public bool IsActive { get; } = true;

    //    protected abstract void Interact();
    //}

    public interface IActive
    {
        bool IsActive { get; }
    }

    public interface IHavePhisics
    {
    }

    public interface IEnemy
    {
        void Attack();
    }

    public interface IInteractible : IActive
    {
        public abstract void Activate();
    }


}
