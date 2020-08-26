using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorscripp : MonoBehaviour {
    public GameObject soru;
    public GameObject vrcamera;
	public GameObject player;
    public GameObject bil;
        void Start()
    {
        vrcamera = GameObject.FindGameObjectWithTag("vrcam");
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        vrcamera.SetActive(false);
        soru.SetActive(false);
        player.SetActive(true);
        yield return new WaitForSeconds(6f);
        bil.SetActive(false);
        yield return new WaitForSeconds(46.50f);
        Destroy(gameObject.GetComponent("Animator"));
        player.SetActive(false);
        soru.SetActive(true);
        vrcamera.SetActive(true);
	}
}

