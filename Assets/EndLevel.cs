using UnityEngine;
using System.Collections;

public class EndLevel: MonoBehaviour 
{
	void ReloadLevel()
	{
		Application.LoadLevel("Level_1");
	}

	void OnTriggerEnter()
	{
		ReloadLevel();
	}
}
