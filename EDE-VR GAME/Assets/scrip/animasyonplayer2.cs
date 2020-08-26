using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class animasyonplayer2 : MonoBehaviour
{
    public GameObject partikles;
    public string sceneToChangeTo;
    public GameObject player2;
    void Start()
    {
        StartCoroutine(EndJump());
    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(0.1f);
        player2.SetActive(true);
        yield return new WaitForSeconds(1.90f);
        partikles.SetActive(false);
        yield return new WaitForSeconds(2.20f);
        SceneManager.LoadScene(sceneToChangeTo);
        Destroy(gameObject.GetComponent("Animator"));
        player2.SetActive(false);

    }
    public void ChangeScene(string scene)
    {

        SceneManager.LoadScene(scene);
    }
}
