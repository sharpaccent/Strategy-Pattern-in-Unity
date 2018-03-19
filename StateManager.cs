using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class StateManager : MonoBehaviour
    {
        public State currentState;

        public Transform mTransform;
        public Rigidbody rigid;
        public Animator anim;
        public float delta;
        public TransformVariable playerTransform;

        void Start()
        {
            mTransform = this.transform;
            anim = GetComponentInChildren<Animator>();
            rigid = GetComponent<Rigidbody>();
            rigid.constraints = RigidbodyConstraints.FreezeRotation;

            if(playerTransform != null)
            {
                playerTransform.value = mTransform;
            }
        }

        void Update()
        {
            delta = Time.deltaTime;

            if(currentState != null)
            {
                currentState.Tick(this);
            }
        }
        
    }
}
