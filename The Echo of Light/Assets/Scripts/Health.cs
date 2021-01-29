using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHP;
    int currentHP=0;
    [SerializeField] string attackerTag;
    [SerializeField] int damageValue;
    
    [Header("Knockback")]
    [SerializeField] float konckbackDuration;
    [SerializeField] float knockbackForce;
    [SerializeField] Rigidbody2D rb2d;

    [SerializeField] ParticleSystem blood;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == attackerTag)
        {
            currentHP -= damageValue;
            Debug.Log(currentHP);
            StartCoroutine(KnockBack(konckbackDuration, knockbackForce, collision.transform));
            blood.Play();
        }
        if (currentHP <= 0)
        {
            blood.Play();
            Destroy(gameObject);
        }
    }

    IEnumerator KnockBack(float knockBackDuration, float knockBackPower, Transform collidingOnbject)
    {
        float timer = 0;
        while(knockBackDuration > timer)
        {
            timer += Time.deltaTime;
            if(collidingOnbject.position.x > transform.position.x)
            {
                Vector2 knockDirection = Vector2.left;
                rb2d.AddForce(knockDirection * knockBackPower);
            }
            else
            {
                rb2d.AddForce(Vector2.right * knockBackPower);

            }


        }
        yield return 0;
    }
}
