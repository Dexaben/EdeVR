using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class direkscene : MonoBehaviour {
	public string sceneToChangeTo;
	public float gazeTime = 2f;

	private float timer;

	private bool gazedAt;
	void Start()
	{
	}

	void Update()
	{
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		if (gazedAt)
		{
			timer += Time.deltaTime;
			if (timer >= gazeTime)
			{
				yield return new WaitForSeconds(5f);
				SceneManager.LoadScene(sceneToChangeTo);
				timer = 0f;
			}
		}
	}
	public void ChangeScene(string scene)
	{

		SceneManager.LoadScene(scene);
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