using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D m_Rigidbody;

    public float thrust = 20f;
    int jumpsLeft;

    public Animator animator;

    public int xspeed = 4;


    Vector2 xMove;

    Transform player;

    float xMovement;

    float yMovement;

    void Start()
    {
        player = gameObject.transform;

        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal");

        yMovement = Input.GetAxis("Vertical");

        xMove = new Vector2(xMovement, yMovement);

        player.Translate(xMove * Time.deltaTime);

        if (xMovement > 0)
        {
            player.localScale = new Vector3(3, 3, 1);
        }
        if (xMovement < 0)
        {
            player.localScale = new Vector3(-3, 3, 1);
        }
        animator.SetFloat("speed", Mathf.Abs(xMovement));
        if (Input.GetKeyDown(KeyCode.Z)||Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_Rigidbody.AddForce(transform.up * thrust);
        }


    }
}