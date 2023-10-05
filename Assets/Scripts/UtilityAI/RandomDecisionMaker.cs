using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public class RandomDecisionMaker : DecisionMaker
    {
        public override AIAction DecideAction(AIAction[] actions)
        {
            return actions[Random.Range(0, actions.Length)];
        }
    }
}