using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class AssignTransform : MonoBehaviour
    {
        public TransformVariable transformVariable;

        void Start()
        {
            transformVariable.value = this.transform;
            Destroy(this);
        }
    }
}
