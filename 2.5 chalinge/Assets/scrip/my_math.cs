using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class my_math : MonoBehaviour
{
    int num = -1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        prodet();
        Debug.Log(num);

    }

    void prodet()
    {
        num = num * 2;
     }
}
