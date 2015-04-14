using UnityEngine;
using System.Collections;

public class PressurePlatePuzzle : MonoBehaviour
{
	
	private Animator anim1;                      // Reference to the animator component.
	private Animator anim2;                      // Reference to the animator component.
	private GameObject player;                  // Reference to the player GameObject.
	private int count;                          // The number of colliders present that should open the doors.
	public GameObject target1;                   // The Door that the trigger will open
	public GameObject target2;                   // The Door that the trigger will open
	private bool openDoor1;                      // bool that checks that there is something on the pressure plate
	private bool openDoor2;                      // bool that checks that there is something on the pressure plate

	// Use this for initialization
	void Start ()
	{
		anim1 = target1.GetComponent<Animator>();
		anim2 = target2.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		anim1.SetBool("Open",openDoor1);
	}

	void OnTriggerEnter (Collider other)
	{
		openDoor1 = true;
		openDoor2 = false;
	}
	
	
	void OnTriggerExit (Collider other)
	{
		//Not used to keep doors open after you hit the pressure plate
	}
}
