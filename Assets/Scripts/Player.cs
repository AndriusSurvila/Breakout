using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    public AudioClip moveSound;
    public AudioClip shootSound;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var offset = transform.position - other.transform.position;

        if (other.gameObject.name == "Ball")
        {
            AudioSystem.Play(shootSound);
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-offset.x, 1);
        }
    }

}
