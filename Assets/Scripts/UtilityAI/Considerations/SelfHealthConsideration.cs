using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    [CreateAssetMenu(fileName = "SelfHealthConsideration", menuName = "Utility AI/Considerations/Health (Self)")]
    public class SelfHealthConsideration : Consideration
    {
        public override float Score(Agent agent)
        {
            return response.Evaluate(agent.RemainingHealth);
        }
    }
}