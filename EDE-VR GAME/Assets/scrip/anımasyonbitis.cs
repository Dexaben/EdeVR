using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anımasyonbitis : MonoBehaviour
{
    public GameObject JumpCam;
    public GameObject vrcam;
    public GameObject reticle;
    public GameObject eventsystem;
    public GameObject cıkısbutonu;
    void Start()
    {
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(1);
        JumpCam.SetActive(true);
        reticle.SetActive(false);
        eventsystem.SetActive(false);
        cıkısbutonu.SetActive(false);
        yield return new WaitForSeconds(30.53f);
        JumpCam.SetActive(true);
        vrcam.SetActive(true);
        reticle.SetActive(true);
        eventsystem.SetActive(true);
        cıkısbutonu.SetActive(true);
    }
}