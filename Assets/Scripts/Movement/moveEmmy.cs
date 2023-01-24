using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using  UnityEngine.UI;

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
    public moveToto Toto;
    public EmmyDia ED;
    public int up = -1;
    public int down = -1;
    public Tutorial tut;
    public Text DialogEmmy;
    public string Emmy;
    private AudioSource Source;
    public AudioClip Move;
    public AudioClip sammeln;

    private void Start()
    {
        Source = GetComponent<AudioSource>();
        Emmy = "";
    }

    public void reset()
    {
        Vector3 Resetposition = new Vector3(-2, 0, 0);
        transform.position = Resetposition;
    }
    public void soundMove()
    {
        Source.clip = Move;
        Source.Play();
    }
    public void collect()
    {
        Source.clip = sammeln;
        Source.Play();
    }
    public void Update()
    {
        DialogEmmy.text = Emmy;
        Vector2 positionV = transform.position;
        positionV.y = Mathf.Clamp(positionV.y, untereGrenze, obereGrenze);
        transform.position = positionV;

        Vector2 positionH = transform.position;
        positionH.x = Mathf.Clamp(positionH.x, linkeGrenze, rechteGrenze);
        transform.position = positionH;

        Vector2 positionE = transform.position;

        if ((Input.GetKeyDown(KeyCode.W) && up != 0 && HO == 0 && Toto.HO==0 && Toto.Unten==1)|| ((Input.GetKeyDown(KeyCode.W) && up != 0 && Toto.Unten ==0 && Toto.HO ==0 && HO == 0)) ||((Input.GetKeyDown(KeyCode.W) && Toto.Unten ==0 && Toto.HO ==1 && HO == 0)))
        {
            Vector2 positionw = Vector2.up;
            transform.Translate(positionw);
            ++up;
           ED.Up();
            soundMove();
        }

        if ((Input.GetKeyDown(KeyCode.S) && down != 0 && HU == 0 && Toto.HU==0 && Toto.Oben==1)|| ((Input.GetKeyDown(KeyCode.S) && down != 0 && Toto.Oben ==0 && Toto.HU ==0 && HU == 0)) ||((Input.GetKeyDown(KeyCode.S) && Toto.Oben ==0 && Toto.HU ==1 && HU == 0)))
        {
            Vector2 positionS = Vector2.down;
            transform.Translate(positionS);
            down++;
            ED.Down();
            soundMove();
        }
        if(Rechts== 1 && (Input.GetKeyDown(KeyCode.RightArrow)) && HR == 0) 
        {
            Vector2 positionr = Vector2.right;
            transform.Translate(positionr);
            ED.Right();
            
        }
        if (Links == 1 && (Input.GetKeyDown(KeyCode.LeftArrow)) && HL == 0)
        {
            Vector2 positionr = Vector2.left;
            transform.Translate(positionr);
            ED.Left();
            
        }
        if ((Input.GetKeyDown(KeyCode.LeftArrow) && tut.tap == 6 ))
        {
            tut.tap++;
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

        if (collision.gameObject.CompareTag("DiaL"))
        {
            Emmy = ("Hier komme ich nicht mehr Raus");
        }

        if ((collision.gameObject.CompareTag("DiaR")))
        {
            Emmy = ("Hier komme ich nicht mehr Raus");
        }
        if (collision.gameObject.CompareTag("Kristall"))
        {
            collect();
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
        if (collision.gameObject.CompareTag("DiaL"))
        {
            Emmy = "";
        }

        if ((collision.gameObject.CompareTag("DiaR")))
        {
            Emmy = "";
        }
    }
    
}
