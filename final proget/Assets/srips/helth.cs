using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHelth;

    // Start is called before the first frame update
    void Start()
    {
        currentHelth = maxHealth;
    }

 void TakeDamage(int amount)
    {
        currentHelth -= amount;
    }
}
