using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScore : MonoBehaviour {

	private float score = 0.0f;
	public Text scoreText;
	public Text highScoreText;

	void OnEnable()
	{
		Plataform.onWin += SaveHighScore;
	}

	void Start()
	{
		highScoreText.text = "Current Best : " + PlayerPrefs.GetFloat ("HighScore");
	}

	// Update is called once per frame
	void Update () 
	{
		score += Time.deltaTime;
		scoreText.text = "Time : " + Mathf.Round (score);
	}

	void SaveHighScore()
	{
		PlayerPrefs.SetFloat("HighScore", Mathf.Round(score));
	}
}
