using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introcam : MonoBehaviour {
	public GameObject vrcamera;
	public GameObject camera;
	void Start () {
		vrcamera = GameObject.FindGameObjectWithTag("vrcam");
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		vrcamera.SetActive (false);
		camera.SetActive (true);
		yield return new WaitForSeconds(36.50f);
		vrcamera.SetActive (true);
		camera.SetActive (false);

	}
}