using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {
	public float rotationSpeed = 5f;
	public float moveSpeed = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(Vector3.forward * moveSpeed);
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(-Vector3.forward * moveSpeed);
		}

		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Rotate(-Vector3.up * rotationSpeed / 2);
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Rotate(Vector3.up * rotationSpeed / 2);
		}
	}
}
