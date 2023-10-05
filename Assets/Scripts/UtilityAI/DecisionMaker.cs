using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecisionMaking.UAI
{
    public abstract class DecisionMaker : MonoBehaviour
    {
        public abstract AIAction DecideAction(AIAction[] actions);
    }
}