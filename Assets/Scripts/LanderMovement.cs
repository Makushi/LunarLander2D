using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class LanderMovement : MonoBehaviour {

	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = transform.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddRelativeForce (Vector2.up * Time.deltaTime * 50);
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			rb.MoveRotation(rb.rotation - 50 * Time.fixedDeltaTime);
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rb.MoveRotation(rb.rotation + 50 * Time.fixedDeltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		
	}
}
