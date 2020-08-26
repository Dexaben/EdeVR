using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunudurdur : MonoBehaviour {
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
				Time.timeScale = 0F;
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

		gazedAt = false;
	}
	public void PointerDown()
	{
		Debug.Log("pointer down");
	}
}