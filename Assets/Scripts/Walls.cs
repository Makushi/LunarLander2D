using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Walls : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D coll) 
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");
	}
}
