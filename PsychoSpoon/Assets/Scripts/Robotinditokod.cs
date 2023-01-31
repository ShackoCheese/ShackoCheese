using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robotinditokod : MonoBehaviour
{
    public gamemanager mygamemanagerScript;
    [SerializeField]
    public GameObject Player;
    public SecurityCamera cam;

    public float robotsebesseg;
    public Rigidbody2D robotRb;
    public GameObject target;
    public GameObject RestPlace;
    public Vector3 jatekos;
    Vector2 rest;
    public Animator anim;

    void Start()
    {
        target = GameObject.FindWithTag("Player");
        rest = RestPlace.transform.position;
    }

    void Update()
    {
        jatekos.x = target.transform.position.x;
        jatekos.y = target.transform.position.y;
    }

    void FixedUpdate()
    {
        if(robotRb.transform.position != RestPlace.transform.position && cam.robotmozgas != true)
        {
            robotRb.transform.position = rest;
            anim.SetFloat("megy", 0);
        }
        if(cam.robotmozgas == true)
        {
            //robotsebesseg = 5;
            //robotRb.MovePosition(transform.position.x + jatekos.x * robotsebesseg * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, jatekos, robotsebesseg * Time.deltaTime);
            anim.SetFloat("megy", 1);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Rest"))
        {
            robotsebesseg = 0;
        }
        
        if(collider.CompareTag("Player"))
        {
            mygamemanagerScript.Respawn();
        }
    }
}
