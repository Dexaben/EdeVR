using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkbölümmenüyoketme : MonoBehaviour
{
    public GameObject menuu;
    void Start()
    {
    }
    void Update()
    {
        menuu = GameObject.FindGameObjectWithTag("menu");
        Destroy(menuu);
    }
}