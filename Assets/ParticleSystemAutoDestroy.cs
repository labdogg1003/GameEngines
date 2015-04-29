using UnityEngine;
using System.Collections;

public class ParticleSystemAutoDestroy : MonoBehaviour 
{
	private ParticleSystem ps;
	
	
	public void Start() 
	{
		ps = GetComponent<ParticleSystem>();
	}
	
	public void Update() 
	{

			Destroy(this.gameObject, .6f);
	}
}