using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float maxAmount;
        [SerializeField] private ResourceBar healthBar;

        private float currentAmount;

        public float RemainingHealth => currentAmount / maxAmount;

        // Start is called before the first frame update
        void Start()
        {
            currentAmount = maxAmount;
            healthBar.UpdateFill(currentAmount / maxAmount);
        }

        public void ApplyDamage(float damage)
        {
            currentAmount = Mathf.Clamp(currentAmount - damage, 0f, maxAmount);
            healthBar.UpdateFill(currentAmount / maxAmount);

            if (currentAmount == 0f)
            {
                BattleManager.Instance.ResetBattle();
            }
        }

        public void Heal(float amount)
        {
            currentAmount = Mathf.Clamp(currentAmount + amount, 0, maxAmount);
            healthBar.UpdateFill(currentAmount / maxAmount);
        }
    }
}