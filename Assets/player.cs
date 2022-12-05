using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpPower;
    public float direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            direction = 1;
        } else if(Input.GetAxis("Horizontal") < 0)
        {
            direction = -1;
        } else 
        {
            direction = 0;
        }
        rb.velocity = new Vector2(speed * direction,rb.velocity.y);

        if(Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up * jumpPower);
        }
    }
}
