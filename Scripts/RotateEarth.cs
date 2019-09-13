using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour {

	public GameObject sun ;
	public float rotateSpeed ;
	public float revolutionSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
		transform.RotateAround (sun.transform.position, Vector3.down, revolutionSpeed * Time.deltaTime);
	}
}
