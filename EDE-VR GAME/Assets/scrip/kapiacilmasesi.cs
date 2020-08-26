using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapiacilmasesi : MonoBehaviour {

    public GameObject ses;
    void Start()
    {
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(24.60f);
        ses.SetActive(true);
        yield return new WaitForSeconds(3f);
        ses.SetActive(false);
    }
}
