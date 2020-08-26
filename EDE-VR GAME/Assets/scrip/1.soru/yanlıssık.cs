using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class yanlıssık : MonoBehaviour {

    public string sceneToChangeTo;
    public GameObject ipucu;

    public float gazeTime = 2f;

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
                ipucu.SetActive(false);
                SceneManager.LoadScene(sceneToChangeTo);
                timer = 0f;
            }
        }
    }
    public void ChangeScene(string scene)
    {

        SceneManager.LoadScene(scene);
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
