using UnityEngine;
using System.Collections;

public class SwingSword : MonoBehaviour
{
	Animator animator;
	public GameObject  character;
	public GameObject sword;

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
		if (currentState.nameHash == Animator.StringToHash("Swing.transition"))
		{
			sword.GetComponent<SphereCollider>().enabled =  true;
			sword.GetComponent<BoxCollider>().enabled =  false;
			animator.SetLayerWeight(1, 0);
		}

		animator.SetBool ("swing", false);
		if(Input.GetMouseButtonDown(0))
		{
			sword.GetComponent<BoxCollider>().enabled =  true;
			sword.GetComponent<SphereCollider>().enabled =  false;
			animator.SetBool ("swing", true);
			animator.SetLayerWeight(1, 1);
		}
	}
}
