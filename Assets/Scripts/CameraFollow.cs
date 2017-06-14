using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	private Vector3 posDiff = Vector3.zero;

	void Start () 
	{
		posDiff = transform.position - target.position;	
	}
		
	void Update ()
	{
		transform.position = target.position + posDiff;
	}

}
