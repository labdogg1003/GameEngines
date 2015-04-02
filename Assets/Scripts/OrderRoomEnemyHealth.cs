using UnityEngine;
using System.Collections;

public class OrderRoomEnemyHealth : MonoBehaviour {

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
			Debug.Log ("hit");
			transform.parent.GetComponent<OrderRoomManager>().lastEnemyKilledTag = this.gameObject.tag;
			Destroy(this.gameObject);
		}
	}
}
