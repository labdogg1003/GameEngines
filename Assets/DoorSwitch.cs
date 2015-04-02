using UnityEngine;
using System.Collections;

public class DoorSwitch : MonoBehaviour {

    private Animator anim;                      // Reference to the animator component.
    private GameObject player;                  // Reference to the player GameObject.
    private int count;                          // The number of colliders present that should open the doors.
    public GameObject target;                   // The Door that the trigger will open
    private bool openDoor;                      // bool that checks that there is something on the pressure plate

    // Use this for initialization
    void Start()
    {
        anim = target.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Open", openDoor);
    }

    void OnTriggerEnter(Collider other)
    {
        openDoor = true;
    }
}
