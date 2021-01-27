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
    [SerializeField] AudioClip flyingSound;
    [SerializeField] AudioClip chasingSound;
    [SerializeField] AudioSource sounds;
    bool playFlying = false;
    bool playChasing = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
            if (playChasing == false)
            {
                sounds.clip = chasingSound;
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
}
