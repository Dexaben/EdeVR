using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {
	public GameObject degistiriliyor;
	public GameObject degistirildi;
	public GameObject ses;
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
		if (gazedAt) {
			timer += Time.deltaTime;
			if (timer >= gazeTime) {
				degistiriliyor.SetActive (true);
				yield return new WaitForSeconds (1f);
				ses.SetActive (true);
				degistiriliyor.SetActive (false);
				QualitySettings.SetQualityLevel (0);
				degistirildi.SetActive (true);
				yield return new WaitForSeconds (2f);
				degistirildi.SetActive (false);
			}
		}
	}
	public void PointerEnter()
	{

		gazedAt = true;
	}

	public void PointerExit()
	{
		degistirildi.SetActive (false);
		degistiriliyor.SetActive (false);
		ses.SetActive (false);
		gazedAt = false;
	}
	public void PointerDown()
	{
		Debug.Log("pointer down");
	}
}
