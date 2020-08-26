using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslama : MonoBehaviour {
	public string sceneToChangeTo;
	public GameObject ses;
	public float gazeTime = 2f;

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
				ses.SetActive (true);
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
		ses.SetActive (false);
		gazedAt = false;
	}
	public void PointerDown()
	{
		Debug.Log("pointer down");
	}
}