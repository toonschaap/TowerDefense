using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	//This script is for the player to move left and right.
public class LeftAndRightMovement : MonoBehaviour {
	
	public float speed = 18;

	private Rigidbody rig;

	// Use this for initialization
	void Start () 
	{
		rig = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKey(KeyCode.D)) {
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}

		else if (Input.GetKey(KeyCode.A)) {
			transform.position += Vector3.back * speed * Time.deltaTime;
		} 

	}
}
