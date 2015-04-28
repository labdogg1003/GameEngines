using UnityEngine;
using System.Collections;

public class KeepCharacterCentered : MonoBehaviour
{
	public float x;
	public float y;
	public float z;
	Vector3 center;
	Quaternion forward;
	// Use this for initialization
	void Start ()
	{
		center = new Vector3(x,y,z);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(gameObject.transform.localPosition != center)
		{
			gameObject.transform.localPosition = center;
			gameObject.transform.localRotation = Quaternion.identity;
		}
	}
}

