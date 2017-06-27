using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinScore : MonoBehaviour 
{
	public Text score;
	public Text highScore;

	void Start () 
	{
		score.text = "Score : " + PlayerPrefs.GetFloat ("CurrentScore");;
		highScore.text = "High Score : " + PlayerPrefs.GetFloat ("HighScore");;
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Escape))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");	
		}
	}
}
