#pragma strict

public var controller = false;

function Start () {

}

function Update ()
{   
    if(controller == true)
    {    
    	var angle = Mathf.Atan2(Input.GetAxis("LookVertical"),Input.GetAxis("LookHorizontal")) * Mathf.Rad2Deg;
    	transform.rotation = Quaternion.Euler(0,angle-90,0);
    	Mathf.Lerp(transform.rotation.eulerAngles.y , angle, Time.time);
    }
    else
    {
        //Debug.Log(Input.GetAxis("LeftClick"));
		var speed = 100;
		var playerPlane = new Plane(Vector3.up, transform.position);
		// Generate a ray from the cursor position
 		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
 		// Determine the point where the cursor ray intersects the plane.
 		// This will be the point that the object must look towards to be looking at the mouse.
 		// Raycasting to a Plane object only gives us a distance, so we'll have to take the distance,
 		//   then find the point along that ray that meets that distance.  This will be the point
 		//   to look at.
 		var hitdist = 0.0;
 		// If the ray is parallel to the plane, Raycast will return false.
 
 		if (playerPlane.Raycast (ray, hitdist))
  		{
    		 // Get the point along the ray that hits the calculated distance.
     		var targetPoint = ray.GetPoint(hitdist);
 
	     	// Determine the target rotation.  This is the rotation if the transform looks at the target point.
    	 	var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
 
     		// Smoothly rotate towards the target point.
     		//transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime); // WITH SPEED
    		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1); // WITHOUT SPEED!!!
 		}
 	}
}