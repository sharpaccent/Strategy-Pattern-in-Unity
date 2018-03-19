using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu]
    public class IsGrounded : StateAction
    {
        public override void Execute(StateManager states)
        {
            Vector3 origin = states.transform.position;
            origin.y += .7f;
            Vector3 dir = -Vector3.up;
            float dis = 1.4f;
            RaycastHit hit;
            Debug.DrawRay(origin, dir * dis);
            if (Physics.Raycast(origin, dir, out hit, dis))
            {
                Vector3 targetPosition = hit.point;
                states.transform.position = targetPosition;
            }

        }

    }
}
