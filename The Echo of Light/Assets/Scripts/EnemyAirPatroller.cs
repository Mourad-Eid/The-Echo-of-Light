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
  
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, rangeRadius, playerLayer);
        if (collision)
        {
            Debug.Log(collision.name);
            ChasePlayer(collision);
        }
        else
            Patrol();
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
            MoveToTarget(hitInfo.transform);
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
