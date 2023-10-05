using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public class Agent : MonoBehaviour
    {
        [SerializeField] private string id;
        [SerializeField] private TextMeshProUGUI statusText;
        [SerializeField] private Health health;
        [SerializeField] private Energy energy;
        [SerializeField] private Agent opponent;
        [SerializeField] private DecisionMaker decisionMaker;
        [SerializeField] private AIAction[] actions;

        private AIAction currentAction;

        private void Start()
        {
            decisionMaker.Init(this);
        }

        public float RemainingEnergy => energy.RemainingEnergy;
        public float RemainingHealth => health.RemainingHealth;
        public Agent Opponent => opponent;
        public string Id => id;

        public IEnumerator PerformAction()
        {
            Display($"{id} is thinking...");
            yield return new WaitForSeconds(2f);
            currentAction = decisionMaker.DecideAction(actions);

            Display($"{id} decides {currentAction.Id}!");
            currentAction.StartAction(this);
            yield return new WaitForSeconds(2);
            currentAction.StopAction(this);

            opponent.RefillEnergy(Random.Range(10f, 20f));
        }

        public void ApplyDamage(float damage)
        {
            health.ApplyDamage(damage);
        }

        public void Heal(float amount)
        {
            health.Heal(amount);
        }

        public void ExpendEnergy(float amount)
        {
            energy.Expend(amount);
        }

        public void RefillEnergy(float amount)
        {
            energy.Refill(amount);
        }

        public void Display(string text)
        {
            statusText.text = text;
        }
    }
}