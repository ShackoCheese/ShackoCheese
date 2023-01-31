using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public GameObject EndCam;

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.CompareTag("Player"))
        {
            StartCoroutine(Backtotitle());
        }
    }

    IEnumerator Backtotitle()
    {
        EndCam.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("TitleScreen");
    }
}
