using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public CanvasGroup TutorialMessage;
    public bool basic;

    private void Start() {
        TutorialMessage.alpha = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
         if(TutorialMessage.alpha == 0){
        TutorialMessage.alpha = 1;
        }
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Player") && basic == true)
        {
            TutorialMessage.alpha = 0;
            Destroy(gameObject);
        }
    }

    private void Update() {
        if (Input.GetKeyDown("e") && TutorialMessage.alpha == 1)
        {
            TutorialMessage.alpha = 0;
            Destroy(gameObject);
        }
    }
}
