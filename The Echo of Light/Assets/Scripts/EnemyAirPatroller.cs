using UnityEngine;

public class EnemyAirPatroller : MonoBehaviour
{
    [Header("Patrolling Points")]
    [SerializeField] Transform leftPatrolPoint;
    [SerializeField] Transform rightPatrolPoint;

    [Header("Movement")]
    bool facingRight = true;
    [SerializeField] int speed = 1;

    [Header("Sight and Range")]
    [SerializeField] float rangeRadius;
    [SerializeField] LayerMask playerLayer;

    [Header("Sound")]
    [SerializeField] float soundRadius;
    [SerializeField] AudioClip flyingSound;
    [SerializeField] AudioClip chasingSound;
    [SerializeField] AudioSource sounds;
    float soundVolume=0;
    bool playFlying = false;
    bool playChasing = false;

    void Start()
    {
        sounds.volume = 0;
        EventManager.current.onChangeSound += OnSoundRadiusChange;
    }

    private void OnDestroy()
    {
        EventManager.current.onChangeSound -= OnSoundRadiusChange;
    }
    // Update is called once per frame
    void Update()
    {
        //chasing and patrolling
        Collider2D collision = Physics2D.OverlapCircle(transform.position, rangeRadius, playerLayer);
        if (collision)
        {          
            ChasePlayer(collision);
            playFlying = false;
        }
        else
        {
            playChasing = false;
            Patrol();
        }

        //sound handling
        Collider2D soundField = Physics2D.OverlapCircle(transform.position, soundRadius, playerLayer);
        if (soundField)
        {
            sounds.volume = 0.6f; 
        }
        else 
        { 
            sounds.volume = 0;
        }

    }

    void MoveToTarget(Transform target)
    {
        Vector2 targetPosition = new Vector2(target.position.x, target.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if ((target.transform.position.x >= transform.position.x && !facingRight)
        || (target.transform.position.x <= transform.position.x && facingRight))
        {
            Flip();
        }
    }

    void Patrol()
    {
        playChasing = false;
        if (playFlying == false)
        {
            sounds.clip = flyingSound;
            sounds.Play();
            playFlying = true;
        }
        if (InsideBoundaries())
        {
            if (facingRight)
            {
                MoveToTarget(rightPatrolPoint);
            }
            else if (!facingRight)
            {
                MoveToTarget(leftPatrolPoint);
            }
        }
        else
        {
            if (transform.position.x < rightPatrolPoint.position.x)
            {
                MoveToTarget(rightPatrolPoint);
            }
            else
                MoveToTarget(leftPatrolPoint);
        }
    }

    void ChasePlayer(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Player")
        {
            if (facingRight)
            {
                sounds.panStereo = -1;
            }
            else
            {
                sounds.panStereo = 1;
            }
            if (playChasing == false)
            {
                sounds.clip = chasingSound;
                sounds.minDistance = 0;
                sounds.maxDistance = 15;
                sounds.Play();
                playChasing = true;
            }
            MoveToTarget(hitInfo.transform);
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
    }
    bool InsideBoundaries()
    {
        if (rightPatrolPoint.position.x >= transform.position.x
            && leftPatrolPoint.position.x <= transform.position.x)
        {
            return true;
        }
        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, rangeRadius);
        Gizmos.DrawWireSphere(transform.position, soundRadius);
    }


    void OnSoundRadiusChange(float newSoundRadius)
    {
        soundRadius = newSoundRadius;
    }
}
