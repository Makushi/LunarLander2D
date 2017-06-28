using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour 
{
	public void StartGame(int mode)
	{
        if (mode == 0)
        {
            PlayerPrefs.SetInt("ShowSpeedGauge", 0);
        }
        else
        {
            PlayerPrefs.SetInt("ShowSpeedGauge", 1);
        }

		UnityEngine.SceneManagement.SceneManager.LoadScene ("LunarLander");	
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
