using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlatformShoot 
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D mRig;
        private float mGroundMoveSpeed = 5f;
        private float mJumpForce = 12f;
        private bool mJumpInput;
        private MainPanel mMainPanel;

        private void Start()
        {
            mRig = GetComponent<Rigidbody2D>();
            mMainPanel = GameObject.Find("MainPanel").GetComponent<MainPanel>();
        }

        private void Update()       // 检测键盘输入应放在 update 中 
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                mJumpInput = true;           
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
            if (mJumpInput) 
            {
                mJumpInput = false;
                mRig.velocity = new Vector2(mRig.velocity.x, mJumpForce);
            }
        }

        private void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.CompareTag("Reward"))
            {
                GameObject.Destroy(coll.gameObject);
                mMainPanel.UpdateScoreTex(1);
            }
            if (coll.gameObject.CompareTag("Door")) 
            {
                SceneManager.LoadScene("GamePassScene");
            }
        }
    }
}
