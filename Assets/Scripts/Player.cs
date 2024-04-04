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
        //AudioSystem.Play(moveSound);
        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        //{
            
        //}
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            AudioSystem.Play(shootSound);
        }
    }

}
