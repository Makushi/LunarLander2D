using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Plataform : MonoBehaviour {

	public delegate void Win();
	public static event Win onWin;

	public delegate void Crash();
	public static event Crash onCrash;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log (coll.collider.transform.eulerAngles.z);
		float collisionAngle = coll.collider.transform.eulerAngles.z;
		if (coll.relativeVelocity.magnitude > 0.6f || (collisionAngle <= 350f && collisionAngle >= 10f))
		{
			if (onCrash != null)
			{
				onCrash ();
			}
			Debug.Log ("Moriste");
		} else
		{
			if (onWin != null)
			{
				onWin ();
			}
			Debug.Log ("Ganaste");

		}
	}
}
