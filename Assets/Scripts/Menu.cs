﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour 
{
	public void StartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("LunarLander");	
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
