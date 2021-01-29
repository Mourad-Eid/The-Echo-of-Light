using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangedAttack : MonoBehaviour
{
    PlayerInput input;
    [Header("Attack")]
    [SerializeField] int hitRate = 1;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firingPosition;
    private float lastHitTime;
    [SerializeField] Animator anim;

   
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponentInParent<PlayerInput>();
        input.playerActionControls.Land.Shoot.performed += _ => Shoot();
    }

    void Shoot()
    {
        if (Time.time > (1 / hitRate) + lastHitTime)
        {
            lastHitTime = Time.time;
            Instantiate(bulletPrefab, firingPosition.position, firingPosition.rotation);
        }

    }
}
