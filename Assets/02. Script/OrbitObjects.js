//****** Donations are greatly appreciated.  ******
//****** You can donate directly to Jesse through paypal at  https://www.paypal.me/JEtzler   ******

var degrees = 10;
var target : Transform;

function Update() {

    transform.RotateAround (target.position, Vector3.up, degrees);
    transform.RotateAround (target.position, Vector3.forward, degrees);
}