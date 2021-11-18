using UnityEngine;

namespace GeekProject
{
    public class TrapGenerator : IFactory
    {
        private readonly DataTraps data;

        public TrapGenerator (DataTraps data)
        {
            this.data = data;
        }

        public IInteractible Create(Vector3 position, Transform papa)
        {
            var trapJump = data.GetTrap();
            var newTrap = Object.Instantiate(trapJump, position, Quaternion.Euler(0, 0, 0), papa);
            newTrap.SetPowers(data.VerticalPower, data.HorisontalPower);
            return newTrap;
        }

    }
} 