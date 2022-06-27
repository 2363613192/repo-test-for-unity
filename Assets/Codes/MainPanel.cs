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

        public void UpdateScoreTex(int score)     // 注意是 public  该函数会被 Player 调用
        {
            int temp = int.Parse(mScoreTex.text);
            mScoreTex.text =  (temp + score).ToString();
        }
    }
}