using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolum4scene : MonoBehaviour {
    public GameObject soru;
    public GameObject vrcamera;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject bolumismi;
    void Start()
    {
        vrcamera = GameObject.FindGameObjectWithTag("vrcam");
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        vrcamera.SetActive(false);
        soru.SetActive(false);
        cam1.SetActive(true);
        cam2.SetActive(false);
        yield return new WaitForSeconds(31f);
        cam1.SetActive(false);
        bolumismi.SetActive(false);
        cam2.SetActive(true);
        yield return new WaitForSeconds(20.30f);
        soru.SetActive(true);
        vrcamera.SetActive(true);
        cam2.SetActive(false);
    }
}