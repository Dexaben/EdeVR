using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iletisimkapa : MonoBehaviour {

    public GameObject iletisimtext;
    public GameObject butonsesi;
    public GameObject kapa;
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
                iletisimtext.SetActive(false);
                butonsesi.SetActive(false);
                kapa.SetActive(false);
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
