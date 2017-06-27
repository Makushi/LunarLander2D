using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Plataform : MonoBehaviour 
{
	public delegate void Win();
	public static event Win onWin;

	void OnCollisionEnter2D(Collision2D coll) 
	{
		Debug.Log (coll.collider.transform.eulerAngles.z);
		float collisionAngle = coll.collider.transform.eulerAngles.z;

		if (coll.relativeVelocity.magnitude > 0.6f || (collisionAngle <= 350f && collisionAngle >= 10f))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");	
		} 
		else
		{
			if (onWin != null)
			{
				onWin ();
			}

			UnityEngine.SceneManagement.SceneManager.LoadScene ("WinScreen");	
		}
	}
}
