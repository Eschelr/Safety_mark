using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time_Score : MonoBehaviour
{
    float timer_i = 30;

    public int score, score1=0, timer_x;
    bool start_Timer = false;
    // Use this for initialization
    void Start()
    {
        //score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer_x = (int)timer_i;
        StartCoroutine(timer3());
        //timetext.text = "倒數:" + timer_x.ToString() + "秒";
    }
    IEnumerator timer3()
    {
        if (timer_i > 0)
        {
            yield return new WaitForSeconds(1);
            timer_i = timer_i - Time.deltaTime;
            start_Timer = true;

        }
        
    }
    public void SetScore(int sc)
    {
        //計算分數
        score = score + sc;
        Debug.Log(score);
        //指定分數的字串
        //scoretext.text =  score.ToString();
        //將分數存到硬碟
        //PlayerPrefs.SetInt("Score", scoreInt);
    }


}
