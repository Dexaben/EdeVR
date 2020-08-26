using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggeryazı : MonoBehaviour {
    public GameObject text;

	void OnTriggerEnter(Collider other) 
    {
        text.SetActive(true);
    }
}

