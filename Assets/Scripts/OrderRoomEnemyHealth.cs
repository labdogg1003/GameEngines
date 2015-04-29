using UnityEngine;
using System.Collections;

public class NewEnemyHealth : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "weapon")
		{
			//Debug.Log ("hit");
			Destroy(this.gameObject);
		}
	}
}
