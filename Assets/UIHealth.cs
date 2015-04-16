using UnityEngine;
using System.Collections;

public class UIHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public GameObject player;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

	// Update is called once per frame
	void Update () {
        PlayerHealth playerHealth = GetComponent<PlayerHealth>();
        if(playerHealth.currentHealth == 2){
            heart3.active = false;
        }
        if (playerHealth.currentHealth == 1)
        {
            heart3.active = false;
            heart2.active = false;
        }
        if (playerHealth.currentHealth == 0)
        {
            heart3.active = false;
            heart2.active = false;
            heart1.active = false;
        }
	}
}
