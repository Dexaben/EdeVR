using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aramenu : MonoBehaviour {
	public GameObject menuu;
	public GameObject menu;
	public GameObject uyarises1;
	public float gazeTime = 4f;

	private float timer;

	private bool gazedAt;
	void Start()
	{
	}

	void Update()
	{
		if (gazedAt) {
			timer += Time.deltaTime;
			if (timer >= gazeTime) {
				menuu.SetActive (true);
				uyarises1.SetActive (true);
				menu.SetActive (true);
				timer = 0f;
			}
		}
	}
	public void PointerEnter()
	{

		gazedAt = true;
	}

	public void PointerExit()
	{
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		gazedAt = false;
		yield return new WaitForSeconds (8f);
		uyarises1.SetActive (false);
		menu.SetActive (false);
		menuu.SetActive (false);
	}
	public void PointerDown()
	{
		Debug.Log("pointer down");
	}
}