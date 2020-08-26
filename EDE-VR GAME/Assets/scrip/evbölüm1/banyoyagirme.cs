using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banyoyagirme : MonoBehaviour {
    public GameObject vrcamera;
    public GameObject player;

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
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
        vrcamera.SetActive(false);
        player.SetActive(true);
        yield return new WaitForSeconds(3.50f);
        player.SetActive(false);
        vrcamera.SetActive(true);
            }
        }
    }
    public void PointerEnter()
    {

        gazedAt = true;
    }

    public void PointerExit()
    {

        gazedAt = false;
    }
    public void PointerDown()
    {
        Debug.Log("pointer down");
    }
}
