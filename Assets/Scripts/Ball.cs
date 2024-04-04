using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    public Transform spawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var brick = other.gameObject.GetComponent<Brick>();
        if(brick != null)
        {
            brick.Damage();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.lives--;
        transform.position = spawnPoint.position;
        rb.velocity = Vector2.up;
    }
}
