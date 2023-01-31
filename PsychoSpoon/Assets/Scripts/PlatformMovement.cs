using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D platformRb;
    public Rigidbody2D playerRigidbody;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        platformRb.MovePosition(platformRb.position + movement * moveSpeed * Time.deltaTime);
    }
}
