using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class club : MonoBehaviour {

	private float force;
	private float pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
		if (Input.GetKey(KeyCode.Space)){			
			force++;
		}
	}
	void setPos(){
		pos = this.transform.localPosition.y;
	}
}
