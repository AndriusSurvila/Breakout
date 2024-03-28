using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int hp = 1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Damage()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
