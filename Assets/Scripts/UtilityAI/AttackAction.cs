using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public class AttackAction : AIAction
    {
        [SerializeField] private ParticleSystem vfx;
        [SerializeField] private float energyCost;
        [SerializeField] private float maxDamage;



        public override void Init(Agent agent)
        {
            
        }

        public override void StartAction(Agent agent)
        {
            vfx.Play();
            agent.ExpendEnergy(energyCost);

            float damage = Random.Range(0, maxDamage);
            agent.Opponent.ApplyDamage(maxDamage);
        }

        public override void StopAction(Agent agent)
        {
            vfx.Stop();
        }
    }
}