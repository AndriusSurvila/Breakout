using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int hp = 1;
    public AudioClip destroySound;
    public AudioClip boomSound;

    public void Damage()
    {
        hp--;
        AudioSystem.Play(boomSound);
        if (hp <= 0)
        {
            Destroy(gameObject);
            AudioSystem.Play(destroySound);
            GameManager.score += 100;
        }
    }
}
