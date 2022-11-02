using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimy_movement : MonoBehaviour
{
    Vector2 xmove;
   Transform Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        xmove = new Vector2(-1.0f, 0.0f);
        Enemy.Translate(xmove * Time.deltaTime);
    }

}
