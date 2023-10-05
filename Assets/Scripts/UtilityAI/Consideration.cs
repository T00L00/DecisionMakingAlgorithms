using System;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public abstract class Consideration : ScriptableObject
    {
        [SerializeField] protected AnimationCurve response;

        public abstract float Score(Agent agent);
    }
}