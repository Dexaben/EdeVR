using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anket : MonoBehaviour {


	public float gazeTime = 4f;

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
				Application.OpenURL("http://strawpoll.me/15054010/");
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
