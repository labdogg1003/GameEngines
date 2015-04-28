using UnityEngine;
using System.Collections;

public class DoorAnimation : MonoBehaviour
{
	public bool requireKey;                     // Whether or not a key is required.
	//public AudioClip doorSwishClip;             // Clip to play when the doors open or close.
	//public AudioClip accessDeniedClip;          // Clip to play when the player doesn't have the key for the door.
	
	
	Animator anim;                      // Reference to the animator component.
	private GameObject player;                  // Reference to the player GameObject.
	private int count;                          // The number of colliders present that should open the doors.
	
	
	void Start ()
	{
		// Setting up the references.
		anim = GetComponent<Animator>();

		player = GameObject.FindGameObjectWithTag("Player");
		Debug.Log (player);
	}
	
	
	void OnTriggerEnter (Collider other)
	{
		// If the triggering gameobject is the player...
		if(other.gameObject == player)
		{
			count++;
		}


	}
	
	
	void OnTriggerExit (Collider other)
	{
		// If the leaving gameobject is the player or an enemy and the collider is a capsule collider...
		if(other.gameObject == player)
			// decrease the count of triggering objects.
			count = Mathf.Max(0, count-1);
	}
	
	
	void Update ()
	{
		// Set the open parameter.
		anim.SetBool("Open",count > 0);
		
		// If the door is opening or closing...
		if(anim.IsInTransition(0) && !GetComponent<AudioSource>().isPlaying)
		{
			// ... play the door swish audio clip.
			//audio.clip = doorSwishClip;
			GetComponent<AudioSource>().Play();
		}
	}
}