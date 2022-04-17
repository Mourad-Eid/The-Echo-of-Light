using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float lifeTime;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DestroyBullet), lifeTime);
        if (transform.rotation.y == 0)
        {
            rb2d.velocity = Vector2.right * bulletSpeed;
        }
        else
            rb2d.velocity = Vector2.left * bulletSpeed;
    }
   
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
