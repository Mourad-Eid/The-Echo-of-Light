using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLandMovement : MonoBehaviour
{
    [SerializeField] int speed = 1;
    [SerializeField] GameObject leftPatrolPoint;
    [SerializeField] GameObject rightPatrolPoint;
    bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Move(float direction)
    {
        Vector3 currentPos = transform.position;
        currentPos.x += direction * speed * Time.deltaTime;
        transform.position = currentPos;
        if ((direction > 0 && !facingRight) || (direction < 0 && facingRight))
        {
            Flip();
        }
    }

    void Patrol()
    { 
        
    
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
    }
}
