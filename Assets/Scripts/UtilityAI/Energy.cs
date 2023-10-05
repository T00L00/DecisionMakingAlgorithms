using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public class Energy : MonoBehaviour
    {
        [SerializeField] private float maxAmount;
        [SerializeField] private ResourceBar energyBar;

        private float currentAmount;

        public float RemainingEnergy => currentAmount / maxAmount;

        // Start is called before the first frame update
        void Start()
        {
            currentAmount = maxAmount;
            energyBar.UpdateFill(currentAmount / maxAmount);
        }

        public void Expend(float amount)
        {
            currentAmount = Mathf.Clamp(currentAmount - amount, 0, maxAmount);
            energyBar.UpdateFill(currentAmount / maxAmount);
        }

        public void Refill(float amount)
        {
            currentAmount = Mathf.Clamp(currentAmount + amount, 0, maxAmount);
            energyBar.UpdateFill(currentAmount / maxAmount);
        }
    }
}