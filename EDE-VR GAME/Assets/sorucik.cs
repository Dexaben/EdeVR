using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorucik : MonoBehaviour {
	public GameObject player;
	void Start()
	{
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		player.SetActive(false);
		yield return new WaitForSeconds(15.0f);
		player.SetActive(true);
	}
}
