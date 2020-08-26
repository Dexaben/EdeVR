using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textopen : MonoBehaviour {
    public GameObject iletisimtext;
    public GameObject butonsesi;
    public GameObject kapa;
    public GameObject text;
    public float gazeTime = 4f;

    private float timer;

    private bool gazedAt;
    void Start()
    {
    }

    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                iletisimtext.SetActive(true);
                text.SetActive(false);
                butonsesi.SetActive(true);
                kapa.SetActive(true);
                timer = 0f;
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

