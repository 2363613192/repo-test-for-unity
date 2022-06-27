// using System.Collections;
// using System.Collections.Generic;  //∂‡”‡œÓ
using UnityEngine;

namespace PlatformShoot 
{
    public class Bullet : MonoBehaviour
    {
        private void Start()
        {
            GameObject.Destroy(this.gameObject, 3f);
        }       

        private void FixedUpdate()
        {
            transform.Translate(12*Time.deltaTime, 0, 0);           
        }
    }
}


