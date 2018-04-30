using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
    public Image image0;
    public Image image1;
    public Image image2;
    public Image image3;
    public Text scoretext;
    public Text timetext;
    public Text scoretext2;
    public Text scoretextthis;
    public Time_Score MyScoreAdd;
    int Add=0, scoreInt;
    int [] Noo;
    public GameObject Canves;
    public GameObject Canves2;



    // Use this for initialization
    void Start () {
        int scoreInt = PlayerPrefs.GetInt("Score");
        Btnclick();
        Canves.SetActive(true);
        Canves2.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        timetext.text = this.GetComponent<Time_Score>().timer_x.ToString();
        if (timetext.text == "0")
        {
            if(scoreInt< Add)
            {
                scoreInt = Add;
                PlayerPrefs.SetInt("Score", scoreInt);
            }
            //將分數存到硬碟
            //PlayerPrefs.SetInt("Score", scoreInt);
            Stop();
        }
        

    }
    public void Btnclick()
    {

        int[] not_safe_cards = { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        Noo = new int[4];

        Noo[0] = Random.Range(1, 6);   //亂數產生
        SwapCards(not_safe_cards, 10);
        Noo[1] = not_safe_cards[1];
        Noo[2] = not_safe_cards[2];
        Noo[3] = not_safe_cards[3];

        SwapCards(Noo, 5);
        Debug.Log(Noo[0] + "," + Noo[1] + "," + Noo[2] + "," + Noo[3]);

        //int total= ;
        image0.overrideSprite = Resources.Load(Noo[0].ToString(), typeof(Sprite)) as Sprite;
        image1.overrideSprite = Resources.Load(Noo[1].ToString(), typeof(Sprite)) as Sprite;
        image2.overrideSprite = Resources.Load(Noo[2].ToString(), typeof(Sprite)) as Sprite;
        image3.overrideSprite = Resources.Load(Noo[3].ToString(), typeof(Sprite)) as Sprite;
    }

    private void SwapCards(int[] cards, int swap_count)
    {
        for (int i = 0; i < swap_count; i++)
        {
            int a = Random.Range(0, cards.Length);
            int b = Random.Range(0, cards.Length);
            // swap
            int temp = cards[a];
            cards[a] = cards[b];
            cards[b] = temp;
        }
    }


    public void count(int No)
    {
        int checkNo = No;
        if (Noo[checkNo] < 5)
        {
            Add += 5;
        }
        else
        {
            Add += -5;
        }
        Debug.Log(Noo[checkNo]);
        scoretext.text = Add.ToString();
    }
    public void Stop()
    {
        int scoreInt = PlayerPrefs.GetInt("Score");
        scoretext2.text = scoreInt.ToString();
        scoretextthis.text = scoretext.text;
        Canves.SetActive(false);
        Canves2.SetActive(true);
    }

}
