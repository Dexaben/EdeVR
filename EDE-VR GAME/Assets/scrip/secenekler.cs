using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secenekler : MonoBehaviour {

    public GameObject secenekler1;
    void Start()
    {
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(1);
        secenekler1.SetActive(false);
        yield return new WaitForSeconds(30.53f);
        secenekler1.SetActive(true);
    }
}
