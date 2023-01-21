using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DruckNormal : MonoBehaviour
{
    public int Triggernormal = 0;
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Emmy") || (collision.gameObject.CompareTag("Toto") || collision.gameObject.CompareTag("Kiste")))
        {           
            Triggernormal += 1;
            print(Triggernormal);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Emmy") || (collision.gameObject.CompareTag("Toto") || collision.gameObject.CompareTag("Kiste") ))
        {           
            Triggernormal -= 1;
            print(Triggernormal);
        }
    }
}

