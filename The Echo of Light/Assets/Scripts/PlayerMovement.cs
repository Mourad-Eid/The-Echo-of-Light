using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlayerMovement : MonoBehaviour
{
    private PlayerActionControls playerActionControls;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] int speed=5;
    [SerializeField] int jumpSpeed=5;
    private float movementInput;
    private bool facingRight = true;
    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
    }
    private void OnEnable()
    {
        playerActionControls.Enable();
    }
    private void OnDisable()
    {
        playerActionControls.Disable();
    }
    void Start()
    {
        playerActionControls.Land.Jump.performed += _ => Jump();
    }

    void Update()
    {
        //movement
        movementInput=playerActionControls.Land.Walk.ReadValue<float>();
        Vector3 currentPos = transform.position;
        currentPos.x += movementInput * speed * Time.deltaTime;
        transform.position = currentPos;
        if ((movementInput > 0 && !facingRight) || (movementInput < 0 && facingRight))
        {
            Flip();
        }
    }
    

    void Jump()
    {
        rb2d.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
    }
}
