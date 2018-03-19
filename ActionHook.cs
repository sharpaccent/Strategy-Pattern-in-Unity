using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class ActionHook : MonoBehaviour
    {
        public Action[] updateActions;
        
        void Update()
        {
            for (int i = 0; i < updateActions.Length; i++)
            {
                updateActions[i].Execute();
            }
        }
    }
}
