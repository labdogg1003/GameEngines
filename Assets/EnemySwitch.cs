using UnityEngine;
using System.Collections;

public class EnemySwitch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject enemy;
    public int once = 0;

    void OnTriggerEnter(Collider other)
    {
        if (once == 0)
        {
            enemy.SetActive(true);
            once++;
        }
    }
}