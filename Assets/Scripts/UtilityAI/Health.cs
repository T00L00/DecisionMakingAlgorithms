using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float maxAmount;

        private float currentAmount;

        // Start is called before the first frame update
        void Start()
        {
            currentAmount = maxAmount;
        }

        public void ApplyDamage(float damage)
        {
            currentAmount -= damage;
        }

        public void Heal(float amount)
        {
            currentAmount = Mathf.Clamp(currentAmount + amount, 0, maxAmount);
        }
    }
}