using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiste : MonoBehaviour
{
    public int Rechts;
    public int Links;
    public int Oben;
    public int Unten;
    public int HR;
    public int HL;
    public int HO;
    public int HU;


    void Update()
    {
        if (Rechts == 1 && (Input.GetKeyDown(KeyCode.RightArrow)) && HR == 0)
        {
            Vector2 positionr = Vector2.right;
            transform.Translate(positionr);
            
        }
        if (Links == 1 && (Input.GetKeyDown(KeyCode.LeftArrow)) && HL == 0)
        {
            Vector2 positionr = Vector2.left;
            transform.Translate(positionr);
            
        }
        if (Input.GetKeyDown(KeyCode.W) && Unten == 1 && HO == 0)
        {
            Vector3 positionw = Vector3.up;
            transform.Translate(positionw);
            
        }

        if (Input.GetKeyDown(KeyCode.S) && Oben == 1 && HU == 0)
        {
            Vector3 positionS = Vector3.down;
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

        }
        if (collision.gameObject.CompareTag("HLinks"))
        {
            HR = 1;

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
