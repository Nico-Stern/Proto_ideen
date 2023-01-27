using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DruckNormal : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip druck;
    public int Triggernormal = 0;
    
    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Emmy") || (collision.gameObject.CompareTag("Toto") || collision.gameObject.CompareTag("Kiste")))
        {           
            Triggernormal = 1;
            Source.clip = druck;
            Source.Play();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Emmy") || (collision.gameObject.CompareTag("Toto") || collision.gameObject.CompareTag("Kiste") ))
        {           
            Triggernormal = 0;            
        }
    }
}

