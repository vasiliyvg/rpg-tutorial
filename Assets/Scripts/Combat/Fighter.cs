using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        public void Attack(CombatTarget target)
        {
            print("Attacked " + target.name + "!");
        }
    }
}