using UnityEngine;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Rigidbody2D))]
public class LanderMovement : MonoBehaviour 
{
	private Rigidbody2D rb;
    private int showGauge;
    public Text speedGauge;

	void Start () 
	{
		rb = transform.GetComponent<Rigidbody2D>();
        showGauge = PlayerPrefs.GetInt("ShowSpeedGauge");
        speedGauge.gameObject.SetActive(Convert.ToBoolean(showGauge));
    }

    void Update()
    {
        float speed = rb.velocity.magnitude;
        speedGauge.text = "Current Speed : " + speed;
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

		if(Input.GetKey(KeyCode.Escape))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");	
		}
	}
}
