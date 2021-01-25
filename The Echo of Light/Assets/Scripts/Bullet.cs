using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DestroyBullet), lifeTime);
    }
   
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
