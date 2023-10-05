using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public abstract class DecisionMaker : MonoBehaviour
    {
        public virtual void Init(Agent agent) { }
        public abstract AIAction DecideAction(AIAction[] actions);
    }
}