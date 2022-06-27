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

        private void Update()       // ����������Ӧ���� update �� 
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

        private void FixedUpdate()  // �漰������������� FixedUpdate
        {
            // GetAxis ƽ�� GatAxisRaw ��ƽ��
            mRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * mGroundMoveSpeed, mRig.velocity.y);
        }
    }
}
