using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLandMovement : MonoBehaviour
{
    [SerializeField] int speed = 5;
    [SerializeField] Transform leftPatrolPoint;
    [SerializeField] Transform rightPatrolPoint;
    [SerializeField] LayerMask collisionLayer;
    [SerializeField] float collisionLength = 0.6f;
    [SerializeField] Vector3 colliderOffsetLeft;
    [SerializeField] Vector3 colliderOffsetRight;

    protected Vector3 currentTarget;
    bool collidedLeft = false;
    bool collidedRight = false;
    bool facingRight = false;
    int direction = 1;


     void Start()
    {
        currentTarget = rightPatrolPoint.position;
        Flip();
    }

    void Update()
    {
        Move(direction);
    }
    void Move(float direction)
    {
        if (transform.position == leftPatrolPoint.position)
        {
            currentTarget = rightPatrolPoint.position;
            Flip();
        }
        else if (transform.position == rightPatrolPoint.position)
        {
            currentTarget = leftPatrolPoint.position;
            Flip();
        }

        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + colliderOffsetRight, transform.position + colliderOffsetRight + Vector3.right * collisionLength);
        Gizmos.DrawLine(transform.position - colliderOffsetLeft, transform.position - colliderOffsetLeft + Vector3.left * collisionLength);
    }
}
