using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentoff : MonoBehaviour {
    public GameObject buton;
    void Start()
    {
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(0);
        Destroy(gameObject.GetComponent("Box Collider"));
        yield return new WaitForSeconds(30.46f);
    }
}