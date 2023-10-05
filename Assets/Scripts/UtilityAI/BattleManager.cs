using DecisionMaking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DecisionMaking.UAI;
using TMPro;

namespace DecisionMaking.UAI
{
    public enum BattleState
    {
        Agent, Critter
    }

    public class BattleManager : MonoBehaviour
    {
        [SerializeField] private Agent npc;
        [SerializeField] private Agent critter;

        private BattleState currentState;

        // Start is called before the first frame update
        void Start()
        {
            currentState = BattleState.Agent;
            StartCoroutine(StartTurn());
        }

        IEnumerator StartTurn()
        {
            if (currentState == BattleState.Agent)
            {
                npc.Display($"{npc.Id}'s Turn");
                yield return new WaitForSeconds(1f);

                yield return StartCoroutine(npc.PerformAction());
                npc.Display($"{npc.Id}'s Turn Ended");
            }
            else
            {
                critter.Display($"{critter.Id}'s Turn");
                yield return new WaitForSeconds(1f);

                yield return StartCoroutine(critter.PerformAction());
                critter.Display($"{critter.Id}'s Turn Ended");
            }
        }

        public void EndTurn()
        {
            currentState = (currentState == BattleState.Agent) ? BattleState.Critter : BattleState.Agent;
            StartCoroutine(StartTurn());
        }

        public void ResetBattle()
        {

        }
    }
}