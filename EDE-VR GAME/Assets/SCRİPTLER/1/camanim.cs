using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class camanim : MonoBehaviour {
	public GameObject vrcamera;
	public string sceneToChangeTo;
	void Start () {
		vrcamera = GameObject.FindGameObjectWithTag("vrcam");
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		vrcamera.SetActive (false);
		yield return new WaitForSeconds(125f);
		SceneManager.LoadScene(sceneToChangeTo);

	}
	public void ChangeScene(string scene)
	{

		SceneManager.LoadScene(scene);
	}
}