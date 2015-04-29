using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemy;
	public GameObject   poof;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


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

		Instantiate( poof,spawnPoints[spawnPointIndex].position,Quaternion.identity);
        (Instantiate (enemy[enemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation)as GameObject).transform.parent = transform.parent;
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
