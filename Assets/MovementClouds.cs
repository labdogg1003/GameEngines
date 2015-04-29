using UnityEngine;
using System.Collections;

public class MovementClouds : MonoBehaviour {

	Animator  animController;
	public GameObject character;
	public GameObject clouds;

	// Use this for initialization
	void Start () 
	{
		animController = character.GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		AnimatorStateInfo currentState = animController.GetCurrentAnimatorStateInfo(0);

		if(Input.GetKeyDown("left shift") &&
		   currentState.nameHash == Animator.StringToHash("Base Layer.WalkFWD"))
		{
			Debug.Log ("Smoke!");
			Instantiate(clouds, character.transform.position, Quaternion.identity);
		}
	}
}
