using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	public GameObject AObject;
	public GameObject SObject;
	public GameObject DObject;
	private int spawner;
	private float timer;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1 * Time.deltaTime;
		if (timer >= 1) {
			spawner = Random.Range (1, 4);
			if (spawner == 1)
				GameObject.Instantiate (AObject, new Vector3 (this.transform.position.x - 0.6f, this.transform.position.y), this.transform.rotation);
			if (spawner == 2)
				GameObject.Instantiate (SObject, new Vector3 (this.transform.position.x, this.transform.position.y), this.transform.rotation);
			if (spawner == 3)
				GameObject.Instantiate (DObject, new Vector3 (this.transform.position.x + 0.6f, this.transform.position.y), this.transform.rotation);
			timer -= 1;
		}
	}
}
