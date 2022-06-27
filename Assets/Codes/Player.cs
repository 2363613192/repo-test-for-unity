using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformShoot 
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D mRig;
        private float mGroundMoveSpeed = 5f;
        private float mJumpForce = 12f;

        private void Start()
        {
            mRig = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()  // 涉及物理运算最好用 FixedUpdate
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                mRig.velocity = new Vector2(mRig.velocity.x, mJumpForce);
                Debug.Log(111);
            }

            // GetAxis 平滑 GatAxisRaw 不平滑
            mRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * mGroundMoveSpeed, mRig.velocity.y);
        }
    }
}
