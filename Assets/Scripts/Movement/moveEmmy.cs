using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEmmy : MonoBehaviour
{
    public float linkeGrenze = -8.5f;
    public float rechteGrenze = 8.5f;
    public float obereGrenze = 4.5f;
    public float untereGrenze = -4.5f;
    public int Rechts;
    public int Links;
    public int HR;
    public int HL;
    public int HO;
    public int HU;

    

    public void Update()
    {
        Vector2 positionV = transform.position;
        positionV.y = Mathf.Clamp(positionV.y, untereGrenze, obereGrenze);
        transform.position = positionV;

        Vector2 positionH = transform.position;
        positionH.x = Mathf.Clamp(positionH.x, linkeGrenze, rechteGrenze);
        transform.position = positionH;

        Vector2 positionE = transform.position;

        if (Input.GetKeyDown(KeyCode.W) && HO == 0)
        {
            Vector2 positionw = Vector2.up;
            transform.Translate(positionw);
        }

        if (Input.GetKeyDown(KeyCode.S) && HU == 0)
        {
            Vector2 positionS = Vector2.down;
            transform.Translate(positionS);
        }
        if(Rechts== 1 && (Input.GetKeyDown(KeyCode.RightArrow)) && HR == 0) 
        {
            Vector2 positionr = Vector2.right;
            transform.Translate(positionr);
        }
        if (Links == 1 && (Input.GetKeyDown(KeyCode.LeftArrow)) && HL == 0)
        {
            Vector2 positionr = Vector2.left;
            transform.Translate(positionr);
        }


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RechtsTrigger"))
        {
            Rechts = 1;          
        }
        if (collision.gameObject.CompareTag("LinksTrigger"))
        {
            Links = 1;
        }
        if (collision.gameObject.CompareTag("HOben"))
        {
            HU =1;
        }
        if (collision.gameObject.CompareTag("HUnten"))
        {
            HO=1;
        }
        if (collision.gameObject.CompareTag("HRechts"))
        {
            HL=1;
        }
        if (collision.gameObject.CompareTag("HLinks"))
        {
            HR=1;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RechtsTrigger"))
            Rechts = 0;
        if (collision.gameObject.CompareTag("LinksTrigger"))
            Links = 0;
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
