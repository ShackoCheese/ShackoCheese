using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenBackground : MonoBehaviour
{
    public GameObject Target;
    public GameObject BackPlace;
    public Rigidbody2D rb;
    Vector2 BP;
    Vector2 Tar;
    public float speed;

    void Start()
    {
        Tar = Target.transform.position;
        BP = BackPlace.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.MovePosition(rb.position + Tar * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Spike"))
        {
            transform.position = BP;
        }
    }
}
