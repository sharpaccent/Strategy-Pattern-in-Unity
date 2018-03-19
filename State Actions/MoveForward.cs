using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu]
    public class MoveForward : StateAction
    {
        public InputManager inpManager;
        public float movementSpeed = 2;

        public override void Execute(StateManager states)
        {
            Vector3 velocity = states.mTransform.forward * inpManager.moveAmount * movementSpeed;
            states.rigid.velocity = velocity;
        }
    }
}
