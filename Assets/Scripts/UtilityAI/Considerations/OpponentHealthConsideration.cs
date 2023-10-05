using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    [CreateAssetMenu(fileName = "OpponentHealthConsideration", menuName = "Utility AI/Considerations/Health (Opponent)")]
    public class OpponentHealthConsideration : Consideration
    {
        public override float Score(Agent agent)
        {
            return response.Evaluate(agent.Opponent.RemainingHealth);
        }
    }
}
