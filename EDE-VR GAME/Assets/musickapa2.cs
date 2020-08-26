using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musickapa2 : MonoBehaviour {
	public GameObject muzik;
	// Use this for initialization
	void Start () {
		muzik = GameObject.FindGameObjectWithTag("music2");
	}

	// Update is called once per frame
	void Update () {
		muzik.SetActive (false);
	}
}
