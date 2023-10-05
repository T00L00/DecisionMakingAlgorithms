using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    [CreateAssetMenu(fileName = "SelfEnergyConsideration", menuName = "Utility AI/Considerations/Energy (Self)")]
    public class SelfEnergyConsideration : Consideration
    {
        public override float Score(Agent agent)
        {
            return response.Evaluate(agent.RemainingEnergy);
        }
    }
}
