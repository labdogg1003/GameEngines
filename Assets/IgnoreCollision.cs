using UnityEngine;
using System.Collections;

public class IgnoreCollision : MonoBehaviour {

	public GameObject ignoreGameObject;
	// Use this for initialization
	void Start () 
	{
		Physics.IgnoreCollision( GetComponent<Collider>(),ignoreGameObject.GetComponent<Collider>());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
