using UnityEngine;

public class EnemyLandPatroller : MonoBehaviour
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

    [SerializeField] AudioClip walkingSound;
    [SerializeField] AudioClip chasingSound;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioSource sounds;
    bool playWalking = false;
    bool playChasing = false;

    void Start()
    {
        sounds.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, rangeRadius, playerLayer);
        if (collision)
        {
            ChasePlayer(collision);
            playWalking = false;
        }
        else
        {
            playChasing = false;
            Patrol();
        }
    }

    void MoveToTarget(Transform target)
    {
        Vector2 targetPosition = new Vector2(target.position.x, transform.position.y);
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
        if (playWalking == false)
        {
            sounds.clip = walkingSound;
            sounds.Play();
            playWalking = true;
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
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            sounds.volume = 0;
    }
}
