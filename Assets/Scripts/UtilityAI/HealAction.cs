using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DecisionMaking.UAI
{
    public class HealAction : AIAction
    {
        [SerializeField] private ParticleSystem vfx;
        [SerializeField] private float energyCost;
        [SerializeField] private float healAmount;

        public override void Init(Agent agent)
        {

        }

        public override void StartAction(Agent agent)
        {
            vfx.Play();
            agent.ExpendEnergy(energyCost);
            agent.Heal(healAmount);
        }

        public override void StopAction(Agent agent)
        {
            vfx.Stop();
        }
    }
}
