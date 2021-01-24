using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] int speed=5;
    // Start is called before the first frame update
    void Start()
    {
        Light2D light2D = GetComponentInChildren<Light2D>();
        light2D.pointLightInnerRadius = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity=new Vector2(Input.GetAxisRaw("Horizontal")*speed,0);
    }
}
