using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yanlissikrobot : MonoBehaviour {
	public GameObject uyarı;
	public GameObject buton;
	public GameObject robot;

	public float gazeTime = 2f;

	private float timer;

	private bool gazedAt;
	void Start()
	{
	}


	void Update()
	{
		if (gazedAt)
		{
			timer += Time.deltaTime;
			if (timer >= gazeTime)
			{
				robot.SetActive (true);
				uyarı.SetActive(true);
				buton.SetActive (false);
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