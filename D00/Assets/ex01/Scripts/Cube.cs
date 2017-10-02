using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public char letter;
	private float speed = 1f;
	// Use this for initialization
	void Start () {
		speed = Random.Range (1, 3);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, -speed * Time.deltaTime, 0);

		destroyCube ();

		if (Input.GetKeyDown(KeyCode.A) && this.letter == 'A'){
			if(this.transform.position.y > -0.5 && this.transform.position.y < 0.5){
				if (this.transform.position.y >= 0){
					Debug.Log("Precision: " + (this.transform.position.y));
				}
				if (this.transform.position.y < 0) {
					Debug.Log("Precision: " + -this.transform.position.y);
				}
				GameObject.Destroy(this.gameObject);
			}
		}
		if (Input.GetKeyDown(KeyCode.S) && this.letter == 'S'){
			if(this.transform.position.y > -0.5 && this.transform.position.y < 0.5){
				if (this.transform.position.y >= 0) {
					Debug.Log("Precision: " + this.transform.position.y);
				}
				if (this.transform.position.y < 0) {
					Debug.Log("Precision: " + -this.transform.position.y);
				}
				GameObject.Destroy(this.gameObject);
			}
		}
		if (Input.GetKeyDown(KeyCode.D) && this.letter == 'D'){
			if(this.transform.position.y > -0.5 && this.transform.position.y < 0.5){
				if (this.transform.position.y >= 0) {
					Debug.Log("Precision: " + this.transform.position.y);
				}
				if (this.transform.position.y < 0) {
					Debug.Log("Precision: " + -this.transform.position.y);
				}
				GameObject.Destroy(this.gameObject);
			}
		}
	}
	void destroyCube()
	{
		if (this.transform.position.y < -0.6)
			GameObject.Destroy (this.gameObject);
	}
}
