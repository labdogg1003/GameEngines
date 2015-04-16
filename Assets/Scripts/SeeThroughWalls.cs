using UnityEngine;
using System.Collections;

public class SeeThroughWalls : MonoBehaviour 
{
	public Camera mainCamera;
	public Material RegularMaterial;
	public Material TransparentMaterial;
	bool isTransparent = false;
	public float duration = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{	
		RaycastHit hit;

		Vector3 forward = mainCamera.transform.TransformDirection(Vector3.forward) * 10;
		Debug.DrawRay(mainCamera.transform.position, forward, Color.green);

		isTransparent = false;

		if(Physics.Raycast( mainCamera.transform.position,mainCamera.transform.forward, out hit))
		{
			if (hit.transform.gameObject == this.gameObject)
			{

				isTransparent = true;

			}
		}

		if(isTransparent && this.renderer.material.color != TransparentMaterial.color)
		{

			this.renderer.material = TransparentMaterial;
		}
		else if(!isTransparent)
		{
			this.renderer.material = RegularMaterial;
		}
	
	}


}
