using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] int speed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity=new Vector2(Input.GetAxisRaw("Horizontal")*speed,0);
    }
}
