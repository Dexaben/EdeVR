using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikackapa : MonoBehaviour {
    public GameObject resim1;
    public GameObject resim2;
    public AudioListener main;
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
                AudioListener.pause = true;
                resim1.SetActive(true);
                resim2.SetActive(false);
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
