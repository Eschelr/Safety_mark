using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G2Manager : MonoBehaviour 
{
    public GameObject[] afabCard; //儲存可以產生的room prefabs
    public Vector3 pos;
    public Text txtTime;
    public Text txtScore;
    public Text txtScorethis;
    public Text txtLevel;

    public float GameTime = 30f;
    public float CardIntervalTime = 1f;
	private float CardReminderTime;
	private bool IsGameOver = false;

	private int TotalScore = 0;
	public int AddScore = 5;
	public int CutScore = 5;

	// Level
	private int Level = 1;
	private int MaxLevel;
	public int[] aLevelScore;
	private float LevelSpeed = 3f;
	// 
	private int HighestScore;

    public GameObject Image;
    public GameObject Canvas;
    public GameObject Canvas2;

    public Text txtHighestScore;


    // Use this for initialization
    void Start () 
	{
        aLevelScore = new int[] { 20, 50,100,1000};
        CardReminderTime = CardIntervalTime;
		HighestScore = PlayerPrefs.GetInt("G2Score");
		MaxLevel = aLevelScore.Length+1;
        Debug.Log(aLevelScore[0]);
        txtLevel.text= "Level "+ Level.ToString();
        Image.SetActive(true);
        StartCoroutine("endtext");
        Canvas.SetActive(true);
        Canvas2.SetActive(false);
    }
    IEnumerator endtext()
    {
        yield return new WaitForSeconds(1.5f);
        Image.SetActive(false);
    }
		
    // Update is called once per frame
    void Update () 
	{

		if (IsGameOver) return;

		GameTime -= Time.deltaTime;
		txtTime.text = Mathf.CeilToInt(GameTime).ToString();
		if (GameTime < 0f)
			G2Over();

		CardReminderTime -= Time.deltaTime;
		if (CardReminderTime <= 0f) {
			CardReminderTime = CardIntervalTime;
			RandomCard();
		}
    }

	void RandomCard()
	{
		int idx_fabcard = Random.Range(0, afabCard.Length);
		pos = new Vector3(Random.Range(-4f, 4f), 11f, 0);
		GameObject obj_card = Instantiate(afabCard[idx_fabcard], pos, Quaternion.identity);

		obj_card.GetComponent<G2Card>().SetSpeed(LevelSpeed);
	}

	void G2Over()
	{
		IsGameOver = true;
        

        if (TotalScore > HighestScore) {
			HighestScore = TotalScore;
			PlayerPrefs.SetInt("G2Score", HighestScore);
		}
        txtHighestScore.text = HighestScore.ToString();
        txtScorethis.text = TotalScore.ToString();
        Canvas.SetActive(false);
        Canvas2.SetActive(true);

    }

    /// <summary>
    /// Adds the total score.
    /// </summary>
    public void AddTotalScore()
	{
		TotalScore += AddScore;
		txtScore.text= TotalScore.ToString();
        Debug.Log(AddScore);

		// Adjust Level
		if (TotalScore >= aLevelScore[Level-1]) {
			Level++;
			if (Level > MaxLevel)
				Level = MaxLevel;

            AddScore += 5;
            CutScore += 5;
            GameTime += 10;
            LevelSpeed += 5f;
            txtLevel.text = "Level "+ Level.ToString();
            Image.SetActive(true);
            StartCoroutine("endtext");
        }
	}

	public void SubTotalScore()
	{
		TotalScore -= CutScore;
		if (TotalScore < 0)
			TotalScore = 0;
		
		txtScore.text= TotalScore.ToString();
        Debug.Log(CutScore);
        

        
    }
}