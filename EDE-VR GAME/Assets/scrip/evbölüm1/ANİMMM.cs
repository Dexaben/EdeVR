using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANİMMM : MonoBehaviour {

    public GameObject vrcamera;
    public GameObject player;
    void Start()
    {
        vrcamera = GameObject.FindGameObjectWithTag("vrcam");
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        vrcamera.SetActive(false);
        player.SetActive(true);
        yield return new WaitForSeconds(41.50f);
        Destroy(gameObject.GetComponent("Animator"));
        player.SetActive(false);
        vrcamera.SetActive(true);
    }
}
