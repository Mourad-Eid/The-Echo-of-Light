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

    // Update is called once per frame
    void Update()
    {
        movementInput=playerActionControls.Land.Walk.ReadValue<float>();
        
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(movementInput * speed, 0);
    }

    void Jump()
    {
        rb2d.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
    }
}
