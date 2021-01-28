using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerInput input;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] int speed=5;
    private float movementInput;
    private bool facingRight = true;

    [Header("Jumping")]
    [SerializeField] int jumpSpeed = 5;
    [SerializeField] bool onGround = false;
    [SerializeField] float groundLength = 0.6f;
    [SerializeField] Vector3 colliderOffsetLeft;
    [SerializeField] Vector3 colliderOffsetRight;
    [SerializeField] LayerMask groundLayer;

    [Header("Physics")]
    [SerializeField] float maxSpeed = 7f;
    [SerializeField] float linearDrag = 4f;
    [SerializeField] float gravity = 1f;
    [SerializeField] float fallMultiplier = 5f;
    
    void Start()
    {
        input.playerActionControls.Land.Jump.performed += _ => Jump();
    }

    void Update()
    {
        //movement
        movementInput=input.playerActionControls.Land.Walk.ReadValue<float>();
        //jump condition
        onGround = Physics2D.Raycast(transform.position + colliderOffsetRight, Vector2.down, groundLength, groundLayer)
            || Physics2D.Raycast(transform.position - colliderOffsetLeft, Vector2.down, groundLength, groundLayer);
    }

    private void FixedUpdate()
    {
        Move(movementInput);
        modifyPhysics();
    }

    void Move(float direction)
    {
        Vector3 currentPos = transform.position;
        currentPos.x += movementInput * speed * Time.deltaTime;
        transform.position = currentPos;
        if ((direction > 0 && !facingRight) || (direction < 0 && facingRight))
        {
            Flip();
        }
    }
    void Jump()
    {
        if (onGround)
        {
            rb2d.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
    }

    void modifyPhysics()
    {
        bool changingDirections = (movementInput > 0 && rb2d.velocity.x < 0) || (movementInput < 0 && rb2d.velocity.x > 0);

        if (onGround)
        {
            if (Mathf.Abs(movementInput) < 0.4f || changingDirections)
            {
                rb2d.drag = linearDrag;
            }
            else
            {
                rb2d.drag = 0f;
            }
            rb2d.gravityScale = 0;
        }
        else
        {
            rb2d.gravityScale = gravity;
            rb2d.drag = linearDrag * 0.05f;
            if (rb2d.velocity.y < 0)
            {
                rb2d.gravityScale = gravity * fallMultiplier;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + colliderOffsetRight, transform.position + colliderOffsetRight + Vector3.down * groundLength);
        Gizmos.DrawLine(transform.position - colliderOffsetLeft, transform.position - colliderOffsetLeft + Vector3.down * groundLength);
    }
}
