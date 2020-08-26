﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzigiac : MonoBehaviour {

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
                AudioListener.pause = false;
                resim1.SetActive(false);
                resim2.SetActive(true);
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