using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ustunegelinceyazicikma : MonoBehaviour {
	public GameObject uyari;
	public GameObject uyarises;
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
				uyarises.SetActive(true);
				uyari.SetActive (true);
				timer = 0f;
			}
		} else {
			uyarises.SetActive(false);
			uyari.SetActive (false);
		}
	}

	public void PointerEnter()
	{

		gazedAt = true;
	}

	public void PointerExit()
	{

		gazedAt = false;
	}
	public void PointerDown()
	{
		Debug.Log("pointer down");
	}
}