using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bölümdeis : MonoBehaviour {
	public string sceneToChangeTo;
	// Use this for initialization
	void Start () {
	}

	void Update () {
		SceneManager.LoadScene(sceneToChangeTo);
	}
	public void ChangeScene(string scene)
	{

		SceneManager.LoadScene(scene);
	}
}
