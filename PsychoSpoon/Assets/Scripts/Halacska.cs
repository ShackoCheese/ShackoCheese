using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halacska : MonoBehaviour
{
    //Változók felvétele.
    public float speed;
    public Transform target;
    public Transform A;
    public Transform B;
    public Transform moveSpot;
    public float spotDis;
    public gamemanager mygamemanagerScript;

    //A hal megkeresi a Játékost a tag-je alapján, amint elindul a játék.
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        //Amíg a hal messzebb van a játékostól, mint a megadott távolság, addig egy előrre megadott A és B pont között mozog.
        if(Vector2.Distance(transform.position, target.position) > spotDis)
        {
            //Ha a hal éppen a B pontban van, akkor elindul az A pont felé.
            if(moveSpot.position == A.position)
            {
                transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);
                if(transform.position == moveSpot.position)
                {
                    moveSpot.position = B.position;
                }
            }

            //Ha a hal éppen az A pontban van, akkor elindul a B pont felé.
            else if(moveSpot.position == B.position)
            {
                transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);
                if(transform.position == moveSpot.position)
                {
                    moveSpot.position = A.position;
                }     
            }
        }

        //Amint a hal közelebb van a játékoshoz, mint a megadott távolság, elindul a játékos felé, amint teljesen hozzáér, a játékos meghal.
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if(transform.position == target.position)
            {
                mygamemanagerScript.Respawn();
            }
        }
    }
}