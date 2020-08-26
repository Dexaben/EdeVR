using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musickapa : MonoBehaviour {
	public GameObject muzik;
	// Use this for initialization
	void Start () {
		muzik = GameObject.FindGameObjectWithTag("music");
	}
	
	// Update is called once per frame
	void Update () {
		muzik.SetActive (false);
	}
}
