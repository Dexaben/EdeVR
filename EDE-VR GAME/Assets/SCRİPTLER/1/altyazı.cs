using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altyazı : MonoBehaviour {
	public GameObject text;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject text6;
	public GameObject text7;
	void Start () {
		StartCoroutine(EndJump());
	}
	IEnumerator EndJump()
	{
		text.SetActive (true);
		yield return new WaitForSeconds(5f);
		text.SetActive (false);
		text1.SetActive (true);
		yield return new WaitForSeconds(3f);
		text1.SetActive (false);
		text2.SetActive (true);
		yield return new WaitForSeconds(4f);
		text2.SetActive (false);
		text3.SetActive (true);
		yield return new WaitForSeconds(5f);
		text3.SetActive (false);
		text4.SetActive (true);
		yield return new WaitForSeconds(5f);
		text4.SetActive (false);
		text5.SetActive (true);
		yield return new WaitForSeconds(5f);
		text5.SetActive (false);
		text6.SetActive (true);
		yield return new WaitForSeconds(4f);
		text6.SetActive (false);
		text7.SetActive (true);
	}
}