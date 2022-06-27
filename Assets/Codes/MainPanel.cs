using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlatformShoot
{
    public class MainPanel : MonoBehaviour
    {
        private Text mScoreTex;

        void Start()
        {
            mScoreTex = transform.Find("ScoreTex").GetComponent<Text>();
        }

        public void UpdateScoreTex(int score)     // ע���� public  �ú����ᱻ Player ����
        {
            int temp = int.Parse(mScoreTex.text);
            mScoreTex.text =  (temp + score).ToString();
        }
    }
}