using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToto : MonoBehaviour
{
    public float linkeGrenze = -8.5f;
    public float rechteGrenze = 8.5f;
    public float obereGrenze = 4.5f;
    public float untereGrenze = -4.5f;
    public int HR;
    public int HL;
    public int HO;
    public int HU;

    public int Oben;
    public int Unten;
    public void Update()
    {
        Vector2 positionV = transform.position;
        positionV.y = Mathf.Clamp(positionV.y, untereGrenze, obereGrenze);
        transform.position = positionV;

        Vector2 positionH = transform.position;
        positionH.x = Mathf.Clamp(positionH.x, linkeGrenze, rechteGrenze);
        transform.position = positionH;

        Vector2 positionT = transform.position;
        
        if (Input.GetKeyDown(KeyCode.LeftArrow) && HL == 0)
        {
            Vector2 positionl = Vector2.left;
            transform.Translate(positionl);
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && HR == 0)
        {
            Vector2 positionr = Vector2.right;
            transform.Translate(positionr);
           
        }
        if (Input.GetKeyDown(KeyCode.W) && Unten == 1 && HO == 0)
        {
            Vector2 positionw = Vector2.up;
            transform.Translate(positionw);
        }

        if (Input.GetKeyDown(KeyCode.S) && Oben == 1 && HU == 0)
        {
            Vector2 positionS = Vector2.down;
            transform.Translate(positionS);
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ObenTrigger"))
        {
            Oben = 1;
        }
        if (collision.gameObject.CompareTag("UntenTrigger"))
        {
            Unten = 1;
        }
        if (collision.gameObject.CompareTag("HOben"))
        {
            HU = 1;
        }
        if (collision.gameObject.CompareTag("HUnten"))
        {
            HO = 1;
        }
        if (collision.gameObject.CompareTag("HRechts"))
        {
            HL = 1;
            print("1");
        }
        if (collision.gameObject.CompareTag("HLinks"))
        {
            HR = 1;
            print("1");
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ObenTrigger"))
            Oben = 0;
        if (collision.gameObject.CompareTag("UntenTrigger"))
            Unten = 0;
        if (collision.gameObject.CompareTag("HOben"))
        {
            HU = 0;
        }
        if (collision.gameObject.CompareTag("HUnten"))
        {
            HO = 0;
        }
        if (collision.gameObject.CompareTag("HRechts"))
        {
            HL = 0;
        }
        if (collision.gameObject.CompareTag("HLinks"))
        {
            HR = 0;
        }
    }


}
