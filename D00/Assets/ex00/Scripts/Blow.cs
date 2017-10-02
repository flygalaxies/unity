using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour {

	float balloonSize = 1;
	float breath = 4;
	float time;
	GameObject balloon;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		breath += 2 * Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.Space) && breath > 0) {
			breath--;
			balloonSize = balloonSize + 1.0f;
			this.transform.localScale = new Vector3 (balloonSize, balloonSize, 0);
		} else {
			balloonSize = balloonSize - 0.03f;
			this.transform.localScale = new Vector3 (balloonSize, balloonSize, 0);
			if (balloonSize < 0) {
				balloonSize = 0;
			}
		}
		if(balloonSize > 10 || balloonSize == 0){
			GameObject.Destroy (this.gameObject);
			Debug.Log ("The Balloon Lived: " + Mathf.RoundToInt(time) + " seconds");
		}
	}
}
