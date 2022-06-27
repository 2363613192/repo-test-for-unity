using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformShoot 
{
    public class CameraCtrl : MonoBehaviour
    {
        private Transform mTarget;

        private void Start()
        {
            // 注意是 FindGameObjectWithTag 而不是 FindGameObject-s-WithTag 
            mTarget = GameObject.FindGameObjectWithTag("Player").transform;
        }

        void LateUpdate()
        {
            transform.localPosition = new Vector3(mTarget.position.x, mTarget.position.y, -10);
        }
    }

}

