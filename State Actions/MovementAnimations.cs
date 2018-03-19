using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu]
    public class MovementAnimations : StateAction
    {
        public string floatName;
        public InputManager inpManager;

        public override void Execute(StateManager states)
        {
            states.anim.SetFloat(floatName, inpManager.moveAmount, .2f, states.delta);
        }
    }
}
