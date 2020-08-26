#pragma strict

var a:float;
function Start () {

}

function Update () {
   transform.Rotate(0, a, 0);
}
function Play () {
   a = 0.3; 
}

function Stop () {
   a = 0;
}