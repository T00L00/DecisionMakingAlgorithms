using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public class UtilityAI : DecisionMaker
    {
        private Agent agent;

        public override void Init(Agent agent)
        {
            this.agent = agent;
        }

        public override AIAction DecideAction(AIAction[] actions)
        {
            // Loop through all the actions and score the actions

            // Score action by looping through the considerations of each action, scoring the considerations
            // then average the consideration scores to get the action score.

            foreach (AIAction a in actions)
            {
                float score = 0f;
                foreach (Consideration c in a.Considerations)
                {
                    score += c.Score(agent);
                }

                score = score / a.Considerations.Length;
                a.Score = score;
            }

            float bestScore = 0f;
            AIAction bestAction = null;
            foreach (AIAction a in actions)
            {
                if (a.Score > bestScore)
                {
                    bestScore = a.Score;
                    bestAction = a;
                }
            }

            return bestAction;
        }
    }
}