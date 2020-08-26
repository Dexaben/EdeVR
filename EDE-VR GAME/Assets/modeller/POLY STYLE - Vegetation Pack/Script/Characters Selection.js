var Character1:GameObject;
var Character2:GameObject;
var Character3:GameObject;
var Character4:GameObject;
var Character5:GameObject;
var Character6:GameObject;

function Character01 () 
{
	onActiveFalse();
    Character1.active=true;
}
function Character02 () 
{
	onActiveFalse();
    Character2.active=true;
}
function Character03 () 
{
	onActiveFalse();
    Character3.active=true;
}
function Character04 () 
{
	onActiveFalse();
    Character4.active=true;
}
function Character05 () 
{
	onActiveFalse();
    Character5.active=true;
}
function Character06 () 
{
	onActiveFalse();
    Character6.active=true;
}
function onActiveFalse()
{
        Character1.active=false;
        Character2.active=false;
        Character3.active=false;
		Character4.active=false;
        Character5.active=false;
		Character6.active=false;
}