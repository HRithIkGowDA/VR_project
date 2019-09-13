using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMainCamera : MonoBehaviour {

	public GameObject sun ;
	public float revolutionSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (sun.transform.position, Vector3.down, revolutionSpeed * Time.deltaTime);
	}
}
