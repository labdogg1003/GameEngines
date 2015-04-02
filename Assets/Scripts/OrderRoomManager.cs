using UnityEngine;
using System.Collections;

public class OrderRoomManager : MonoBehaviour
{
	private int counter;
	public string lastEnemyKilledTag = "";

	private Animator anim;                      // Reference to the animator component.
	public GameObject target;                   // The Door that the trigger will open

	// Use this for initialization
	void Start ()
	{
		anim = target.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(lastEnemyKilledTag != "")
		{
			Debug.Log(lastEnemyKilledTag);
		}

		if(lastEnemyKilledTag != "")
		{
			if(counter == 0)
			{
				if(lastEnemyKilledTag == "blue")
				{
					counter ++;
					lastEnemyKilledTag = "";
				}
				else
				{
					counter = 0;
					lastEnemyKilledTag = "";
				}
			}
			else if(counter == 1)
			{
				if(lastEnemyKilledTag == "yellow")
				{
					counter ++;
					lastEnemyKilledTag = "";
				}
				else
				{
					counter = 0;
					lastEnemyKilledTag = "";
				}
			}
			else if(counter == 2)
			{
				if(lastEnemyKilledTag =="green")
				{
					counter ++;
					lastEnemyKilledTag = "";
				}
				else
				{
					counter = 0;
					lastEnemyKilledTag = "";
				}
			}
			else if(counter == 3)
			{
				if(lastEnemyKilledTag == "red")
				{
					counter ++;
					lastEnemyKilledTag = "";
				}
				else
				{
					counter = 0;
					lastEnemyKilledTag = "";
				}
			}
			else
			{
			}

			if(counter == 4)
			{
				anim.SetBool("Open",true);
			}
		}
	}
}
