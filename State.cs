using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu]
    public class State : ScriptableObject
    {
        public List<StateAction> actions = new List<StateAction>();

        public void Tick(StateManager states)
        {
            for (int i = actions.Count -1; i >=0 ; i--)
            {
                actions[i].Execute(states);
            }
        }
    }
}
