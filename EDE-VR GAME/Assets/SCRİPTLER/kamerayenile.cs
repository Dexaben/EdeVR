using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerayenile : MonoBehaviour {
	public GameObject foto;
	// Use this for initialization
	void Start () {
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		foto = GameObject.FindGameObjectWithTag ("vrcam");
		yield return new WaitForSeconds (3f);
		foto.SetActive(false);
		foto.SetActive(true);
	}
	void Update () {
		
	}
}
