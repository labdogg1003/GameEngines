using UnityEngine;
using System.Collections;

public class rotateScript : MonoBehaviour {

	public float xRotation = 90.0f;
	public float xRotation1 = 0.0f;
	public float RotationSpeed = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate ( Vector3.up * ( RotationSpeed * Time.deltaTime ) );
	}
}
