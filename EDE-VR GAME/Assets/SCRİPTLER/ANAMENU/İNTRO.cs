using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class İNTRO : MonoBehaviour {
	public GameObject logo;
	public GameObject uyarı;
	public GameObject kulaklık;
	public GameObject tubi;
	public string sceneToChangeTo;

	void Start()
	{
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		yield return new WaitForSeconds (4.5f);
		logo.SetActive (false);
		uyarı.SetActive (true);
		yield return new WaitForSeconds (4f);
		uyarı.SetActive (false);
		kulaklık.SetActive (true);
		yield return new WaitForSeconds (4f);
		kulaklık.SetActive (false);
		tubi.SetActive (true);
		yield return new WaitForSeconds (3.4f);
		SceneManager.LoadScene (sceneToChangeTo);
	}
			public void ChangeScene(string scene)
			{

				SceneManager.LoadScene(scene);
			}
}

