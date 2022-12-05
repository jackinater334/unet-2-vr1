using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ScreneManagment;
public class start_menu : MonoBehaviour
{
    public void PlayGame ()
    {
        ScreneManager.LoadScene(ScreneManager.GetActiveScene().buildIndex + 1);
    }
}
