using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public moveEmmy Emmy;
    public TotoDia TD;
    public int left = -1;
    public int right = -1;
    public Tutorial tut;
    public Text DialogToto;
    public string Toto;
    private AudioSource Source;
    public AudioClip Move;
    public AudioClip sammeln;
    public menu Menu;

    private void Start()
    {
        Source = GetComponent<AudioSource>();
        Toto = "";
    }
    public void reset()
    {
        Vector3 Resetposition = new Vector3(2, 0, 0);
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
        DialogToto.text = Toto;
        Vector2 positionV = transform.position;
        positionV.y = Mathf.Clamp(positionV.y, untereGrenze, obereGrenze);
        transform.position = positionV;

        Vector2 positionH = transform.position;
        positionH.x = Mathf.Clamp(positionH.x, linkeGrenze, rechteGrenze);
        transform.position = positionH;

        Vector2 positionT = transform.position;
        
        if ((Input.GetKeyDown(KeyCode.LeftArrow)&& Menu.Tabs !=1 && left !=0 && HL == 0 && Emmy.HL==0 && Emmy.Links==1) || Menu.Tabs !=1&& ((Input.GetKeyDown(KeyCode.LeftArrow) && left != 0 && Emmy.Links ==0 && Emmy.HL ==0 && HL == 0)) ||Menu.Tabs !=1&& ((Input.GetKeyDown(KeyCode.LeftArrow) && left != 0 && Emmy.Links ==0 && Emmy.HL ==1 && HL == 0)))
        {
            Vector3 positionl = Vector3.left;
            transform.Translate(positionl);
            left++;
            TD.Left();
            soundMove();
        }
        if (Menu.Tabs !=1&& (Input.GetKeyDown(KeyCode.RightArrow) && right !=0 && HR == 0 && Emmy.HR==0 && Emmy.Rechts==1) ||Menu.Tabs !=1&&  ((Input.GetKeyDown(KeyCode.RightArrow) && right != 0 && Emmy.Rechts ==0 && Emmy.HR ==0 && HR == 0)) ||Menu.Tabs !=1&& ((Input.GetKeyDown(KeyCode.RightArrow) && Emmy.Rechts ==0 && Emmy.HR ==1 && HR == 0)))
        {
            Vector3 positionr = Vector3.right;
            transform.Translate(positionr);
            right++;
            TD.Right();
            soundMove();
        }
        if (Menu.Tabs !=1&& Input.GetKeyDown(KeyCode.W) && Unten == 1 && HO == 0)
        {
            Vector3 positionw = Vector3.up;
            transform.Translate(positionw);
            TD.Up();
        }

        if (Menu.Tabs !=1&& Input.GetKeyDown(KeyCode.S) && Oben == 1 && HU == 0)
        {
            Vector3 positionS = Vector3.down;
            transform.Translate(positionS);
            TD.Down();
           
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

        if (collision.gameObject.CompareTag("DiaU"))
        {
            Toto = "Ich stecke fest";
        }

        if (collision.gameObject.CompareTag("DiaD"))
        {
            Toto = "Ich stecke fest";
        }
        if (collision.gameObject.CompareTag("Kristall"))
        {
            collect();
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
        if (collision.gameObject.CompareTag("DiaU"))
        {
            Toto = "";
        }

        if (collision.gameObject.CompareTag("DiaD"))
        {
            Toto = "";
        }
    }
    

}
