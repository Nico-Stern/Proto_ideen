using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToto : MonoBehaviour
{
    void Update()
    {
        Vector2 position = transform.position;
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector2 positionl = Vector2.left;
            transform.Translate(positionl);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector2 positionr = Vector2.right;
            transform.Translate(positionr);
        }
        
        
           
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Emmy") && (Input.GetKeyDown(KeyCode.W)))
        {
            
                Vector2 positionw = Vector2.up;
                transform.Translate(positionw);
        }
    }
}
