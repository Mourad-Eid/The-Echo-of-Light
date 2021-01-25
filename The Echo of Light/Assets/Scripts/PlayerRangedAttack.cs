using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangedAttack : MonoBehaviour
{

    PlayerInput input;
    Camera camera;
    [Header("Attack")]
    [SerializeField] int hitRate = 1;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firingPosition;
    [SerializeField] float offset;
    [SerializeField] float bulletForce=15f;
    private float lastHitTime;
    
   
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponentInParent<PlayerInput>();
        camera = Camera.main;
        input.playerActionControls.Land.Shoot.performed += _ => Shoot();
    }

    void Shoot()
    {
        if (Time.time > (1 / hitRate) + lastHitTime)
        {           
            lastHitTime = Time.time;
            GameObject bullet= Instantiate(bulletPrefab, firingPosition.position, transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firingPosition.right * bulletForce, ForceMode2D.Impulse);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = input.playerActionControls.Land.MousePosition.ReadValue<Vector2>();
        Vector3 difference = camera.ScreenToWorldPoint(mousePos) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
    }
}
