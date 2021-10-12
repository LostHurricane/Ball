using UnityEngine;

namespace GeekProject
{
    public class BonusGenerator
    {
        private readonly DataBonuses data;

        public BonusGenerator(DataBonuses data)
        {
            this.data = data;
        }

        public IInteractible Create(Vector3 position, Transform papa)
        {
            Debug.Log("Creating Tra");
            var Bonus = data.GetBonus();
            var newBonus = Object.Instantiate(Bonus, position, Quaternion.Euler(0, 0, 0), papa);
            return newBonus;
        }
    }
}