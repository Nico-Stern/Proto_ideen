using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Itemzaehler Kristall;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || (collision.gameObject.CompareTag("Player2")))
            gameObject.SetActive(false);
            Kristall.Kristalle += 1;
    }
}

