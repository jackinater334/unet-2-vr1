using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    float xMovement;
    float yMovement;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal");
        yMovement = Input.GetAxis("Vertical");
        xMove = new Vector2(xMovement, yMovement);
        player.Translate(xMove * Time.deltaTime);
        if (Input.GetAxis("Horizontal")< 0)
        {
            player.localScale = new Vector3 (7, 7, 1);
        }
        if (Input.GetAxis ("Horizontal")< 0)
        {
            player.localScale = new Vector3(-7, 7, 1);
        }
    }
}