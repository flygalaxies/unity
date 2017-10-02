using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	private float force;
	private float speed;
	private float friction;
	private bool charging = false;
	// Use this for initialization
	void Start () {
		friction = 0.004f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			charging = true;
			force += 0.004f;
		}
		if (!Input.GetKey(KeyCode.Space) && charging){
			charging = false;
			speed = force;
			force = 0;
		}
		if (this.absolute(speed) != 0) {
			if (speed > 0) {
				speed -= friction;
			}
			else
			{
				speed += friction;
			}
		}
		if (absolute(speed) < 0.04f)
			speed = 0;
		this.collision ();
		this.transform.localPosition += new Vector3 (0, speed, 0);
	}

	float absolute(float Speed){
		if (Speed < 0) {
			Speed *= -1;
		}
		return Speed;
	}


	void collision()
	{
		if (this.transform.position.y + this.speed >= 4.7f || this.transform.position.y + this.speed <= -2.7f)
			this.speed *= -1;
		
	}
}
