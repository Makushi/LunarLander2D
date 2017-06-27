using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScore : MonoBehaviour 
{
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

	void Update () 
	{
		score += Time.deltaTime;
		scoreText.text = "Time : " + Mathf.Round (score);
	}

	void SaveHighScore()
	{
		float lastScore = PlayerPrefs.GetFloat ("HighScore", 0);
		if (lastScore == 0 || score < lastScore)
		{
			PlayerPrefs.SetFloat ("HighScore", Mathf.Round (score));
		}
		PlayerPrefs.SetFloat ("CurrentScore", Mathf.Round (score));
	}
}
