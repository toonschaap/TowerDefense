using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	// Use this for initialization
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Fire();
		}
	}
	
	// Update is called once per frame

		void Fire()
		{
			// Create the Bullet from the Bullet Prefab
			var bullet = (GameObject)Instantiate(
				bulletPrefab,
				bulletSpawn.position,
				bulletSpawn.rotation);

			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 40;

			// Destroy the bullet after 2 seconds
			Destroy(bullet, 4.0f);        
		}
	}

