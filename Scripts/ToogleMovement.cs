using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleMovement : MonoBehaviour {

	public GameObject cameraObject ;
	public GameObject centerObject ;
	public float revolutionSpeed;
	public TextMesh textBox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void checkToggle(){
		if (textBox.text == "Pause") {
			stopMovement ();
		} else {
			startMovement ();
		}
	}

	public void startMovement(){
		transform.RotateAround (centerObject.transform.position, Vector3.down, revolutionSpeed * Time.deltaTime);
		gameObject.name = "Pause";
	}

	public void stopMovement(){
		transform.RotateAround (centerObject.transform.position, Vector3.down,0 );
		gameObject.name = "Start";
	}

}
