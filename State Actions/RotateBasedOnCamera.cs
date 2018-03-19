using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu]
    public class RotateBasedOnCamera : StateAction
    {
        public TransformVariable cameraTransform;
        public InputManager inpManager;
        public float speed = 8;

        public override void Execute(StateManager states)
        {
            if (cameraTransform.value == null)
                return;

            float h = inpManager.horizontal.value;
            float v = inpManager.vertical.value;
  
            Vector3 targetDir = cameraTransform.value.forward * v;
            targetDir += cameraTransform.value.right * h;
            targetDir.Normalize();

            targetDir.y = 0;
            if (targetDir == Vector3.zero)
                targetDir = states.transform.forward;

            Quaternion tr = Quaternion.LookRotation(targetDir);
            Quaternion targetRotation = Quaternion.Slerp(
                states.transform.rotation, tr,
                states.delta * inpManager.moveAmount * speed);

            states.transform.rotation = targetRotation;
        }
    }
}
