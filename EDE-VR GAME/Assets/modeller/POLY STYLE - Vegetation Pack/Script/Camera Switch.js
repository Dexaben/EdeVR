var camera1:GameObject;
var camera2:GameObject;
var camera3:GameObject;
var camera4:GameObject;
var camera5:GameObject;
var camera6:GameObject;
var camera7:GameObject;
var camera8:GameObject;
var camera9:GameObject;
var camera10:GameObject;

function Update () 
{
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
                onActiveFalse();
                camera1.active=true;
        }
		 if(Input.GetKeyUp(KeyCode.Alpha2))
        {
                onActiveFalse();
                camera2.active=true;
        } if(Input.GetKeyUp(KeyCode.Alpha3))
        {
                onActiveFalse();
                camera3.active=true;
        } if(Input.GetKeyUp(KeyCode.Alpha4))
        {
                onActiveFalse();
                camera4.active=true;
        } if(Input.GetKeyUp(KeyCode.Alpha5))
        {
                onActiveFalse();
                camera5.active=true;
        }
		 if(Input.GetKeyUp(KeyCode.Alpha6))
        {
                onActiveFalse();
                camera6.active=true;
        }
		 if(Input.GetKeyUp(KeyCode.Alpha7))
        {
                onActiveFalse();
                camera7.active=true;
        }
		 if(Input.GetKeyUp(KeyCode.Alpha8))
        {
                onActiveFalse();
                camera8.active=true;
        }
		 if(Input.GetKeyUp(KeyCode.Alpha9))
        {
                onActiveFalse();
                camera9.active=true;
        }
		 if(Input.GetKeyUp(KeyCode.C))
        {
                onActiveFalse();
                camera10.active=true;
        }
}
function onActiveFalse()
{
        camera1.active=false;
        camera2.active=false;
        camera3.active=false;
		camera4.active=false;
        camera5.active=false;
		camera6.active=false;
        camera7.active=false;
        camera8.active=false;
		camera9.active=false;
		camera10.active=false;
}