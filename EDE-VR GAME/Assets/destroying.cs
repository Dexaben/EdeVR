using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroying : MonoBehaviour {
	public GameObject kamera;
	// Use this for initialization
	void Start () {
		kamera = GameObject.FindGameObjectWithTag("vrcam");
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(kamera);
	}
}
