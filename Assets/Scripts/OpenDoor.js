 
// simple lerp up and down movement
var targeti : Transform;
var moveSpeed : float = 5.0;
var upMaxDistance : float = 10.0;
var openCloseSound : AudioClip;
private var initPosition : Vector3;
private var openDoor : boolean = false;
 
function Start() {
    initPosition = targeti.transform.position; 
}
 
function Update () 
{
   
}
 
function OnTriggerEnter() {
    openDoor = true;   
    GetComponent.<AudioSource>().PlayOneShot(openCloseSound);
}
 
function OnTriggerExit() {
    yield WaitForSeconds(2);
    openDoor = false;  
    GetComponent.<AudioSource>().PlayOneShot(openCloseSound);
}