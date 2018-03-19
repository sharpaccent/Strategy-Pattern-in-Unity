using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public abstract class StateAction : ScriptableObject
    {
        public abstract void Execute(StateManager states);
    }
}
