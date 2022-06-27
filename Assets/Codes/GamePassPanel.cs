using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace PlatformShoot
{
    public class GamePassPanel : MonoBehaviour
    {
        void Start()
        {
            transform.Find("ResetGameBtn").GetComponent<Button>().onClick.AddListener(() =>
            {
                SceneManager.LoadScene("SampleScene");
            });    // lameda ±Ì¥Ô Ω
        }

        void Update()
        {

        }
    }
}