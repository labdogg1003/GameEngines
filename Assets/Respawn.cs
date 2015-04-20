using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour 
{
	int playerHealth;
	int killWallHeight = 0;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Get Player Health Every Update Frame
		playerHealth = GetComponent<nPlayerHealth>().currentHealth;

		if(playerHealth <= 0 || transform.position.y <= killWallHeight)
		{
			ReloadLevel();
		}
	}

	void ReloadLevel()
	{
		Application.LoadLevel("Level_1");
	}
}
