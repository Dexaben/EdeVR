using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableplayercam : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("playercam");
	}

	// Update is called once per frame
	void Update () {
		player.SetActive (true);
	}
}
