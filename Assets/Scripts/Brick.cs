using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Brick : MonoBehaviour
{
    [SerializeField] int hp = 1;
    public AudioClip destroySound;
    public AudioClip boomSound;
    public GameObject explosionParticles;

    private void Start()
    {
        transform
            .DOScale(Vector3.one, 1f)
            .SetDelay(Random.Range(0.25f, 0.5f))
            .ChangeStartValue(Vector3.zero)
            .SetEase(Ease.OutBounce);
    }

    public void Damage()
    {
        hp--;
        AudioSystem.Play(boomSound);
        if (hp <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosionParticles, transform.position, Quaternion.identity);
            AudioSystem.Play(destroySound);
            GameManager.score += 100;
            Camera.main.DOShakePosition(0.2f, 1.2f, 20);
        }
    }
}
