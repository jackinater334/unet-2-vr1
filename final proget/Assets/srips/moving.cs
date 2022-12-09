using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    // Start is called before the first frame update






    public int xspeed = 10;

    Vector2 xMove;

    Transform player;

    float xMovement;

    float yMovement;

    Rigidbody2D rb;

    public int Thrust = 250;
    
    void Start()
    {
        player = gameObject.transform;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //bacic movement
        xMovement = Input.GetAxis("Horizontal");

        yMovement = Input.GetAxis("Vertical");

        xMove = new Vector2(xMovement, yMovement);
        
        player.Translate(xMove *xspeed * Time.deltaTime);

        if (xMovement > 0)
        {
            player.localScale = new Vector3(2, 2, 1);
        }
        if (xMovement < 0)
        {
            player.localScale = new Vector3(-2, 2, 1);
        }
        

        //jumping code

        if (rb.velocity.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.Z)||Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(transform.up * Thrust);
            }
        }

    }
}
