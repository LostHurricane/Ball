using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public interface ISubscribable : IInteractible, IActive
    {
        public delegate System.Action Effect();
    
    }
}