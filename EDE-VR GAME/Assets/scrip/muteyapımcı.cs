using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteyapımcı : MonoBehaviour {
    public GameObject muzik;
    public GameObject butonsesi;
    public GameObject kapatbutonu;

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
                muzik.SetActive(false);
                butonsesi.SetActive(true);
                kapatbutonu.SetActive(true);
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

