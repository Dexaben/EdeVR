using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunesiackapa2 : MonoBehaviour {
    public GameObject resim1;
    public GameObject resim2;
    public GameObject isik;
    public GameObject directionallight;
    public GameObject directionallight2;
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
                directionallight.SetActive(false);
                directionallight2.SetActive(true);
                resim1.SetActive(false);
                resim2.SetActive(true);
                isik.SetActive(true);
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

