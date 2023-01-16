using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEmmy : MonoBehaviour
{

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector2 positionw = Vector2.up;
            transform.Translate(positionw);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector2 positionS = Vector2.down;
            transform.Translate(positionS);
        }

        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Toto"))
        {
            
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
    }
}
