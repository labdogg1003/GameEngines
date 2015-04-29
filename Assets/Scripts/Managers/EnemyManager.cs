using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemy;
	public GameObject   poof;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    public int spawned = 0;
    public int spawns = 0;

	private Animator anim;                      // Reference to the animator component.
	public GameObject target;                   // The Door that the trigger will open

    void Start ()
    {
		if(transform.GetComponent<Animator>()!=  null)
		{
			anim = target.GetComponent<Animator>();
		}
    }


    void Spawn ()
    {
		int enemyIndex      = Random.Range (0, enemy.Length);
        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        if (spawned < spawns)
        {
            Instantiate(poof, spawnPoints[spawnPointIndex].position, Quaternion.identity);
            (Instantiate(enemy[enemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation) as GameObject).transform.parent = transform.parent;
            spawned++;
        } 
    }

	void OnTriggerEnter()
	{
		Debug.Log ("Spawning Enemies");
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		if(transform.GetComponent<MeshCollider>()!=  null)
		{
			transform.GetComponent<MeshCollider>().enabled = false;
		}

		if(transform.GetComponent<BoxCollider>()!=  null)
		{
			transform.GetComponent<BoxCollider>().enabled = false;
		}

		if(transform.GetComponent<Animator>()!=  null)
		{
			anim.SetBool("Open",true);
		}
	}
}
