using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int hp = 1;

    public void Damage()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(gameObject);
            GameManager.score += 100;
        }
    }
}
