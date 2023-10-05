using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public abstract class AIAction : MonoBehaviour
    {
        [SerializeField] protected string id;
        [SerializeField] protected Consideration[] considerations;

        public Consideration[] Considerations => considerations;
        public float Score { get; set; }

        public string Id => id;

        public abstract void Init(Agent agent);
        public abstract void StartAction(Agent agent);
        public abstract void StopAction(Agent agent);
        public virtual void UpdateAction(Agent agent) { }
    }
}