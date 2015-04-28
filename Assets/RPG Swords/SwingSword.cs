using UnityEngine;
using System.Collections;

public class SwingSword : MonoBehaviour
{
	Animator animator;
	public GameObject  character;

	// Use this for initialization
	void Start () 
	{
		//Get The Animator For The Player Graphic.
		animator = character.GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		AnimatorStateInfo currentState = animator.GetCurrentAnimatorStateInfo(1);
		Debug.Log(currentState.nameHash);
		if (currentState.nameHash == Animator.StringToHash("Swing.transition"))
		{
			animator.SetLayerWeight(1, 0);
			Debug.Log ("Working");
		}

		animator.SetBool ("swing", false);
		if(Input.GetMouseButtonDown(0))
		{
			animator.SetBool ("swing", true);
			animator.SetLayerWeight(1, 1);
		}
	}
}
