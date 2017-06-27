using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Walls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Perdio");
	}
}
