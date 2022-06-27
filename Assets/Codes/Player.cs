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

        private void Update()       // 检测键盘输入应放在 update 中 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                mRig.velocity = new Vector2(mRig.velocity.x, mJumpForce);
                Debug.Log(111);
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                Debug.Log(222);
                var bullet = Resources.Load<GameObject>("Bullet");
                GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
            }
        }

        private void FixedUpdate()  // 涉及物理运算最好用 FixedUpdate
        {
            // GetAxis 平滑 GatAxisRaw 不平滑
            mRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * mGroundMoveSpeed, mRig.velocity.y);
        }
    }
}
