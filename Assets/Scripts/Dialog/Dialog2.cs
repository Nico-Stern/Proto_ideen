using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class Dialog2 : MonoBehaviour
{
    public Text DialogEmmy;
    public Text DialogToto;
    public Text DialogNico;
    public Text DialogGeschichte;
    public Text WDia;
    public Text SDia;
    public Text DiaL;
    public Text DiaR;
    public string Geschichte;
    public string Emmy;
    public string Nico;
    public string Toto;
    public string W;
    public string S;
    public string Links;
    public string Rechts;
    public int Klicks = 1;
    public int BewegungL = 0;
    public int BewegungR = 0;
    public int BewegungW = 0;
    public int BewegungS = 0;
    public int ergebnis = 0;
    public GameObject Herzen;
    public GameObject Lifescript;
    public GameObject Kristalle;
    public GameObject Blackscreen;
    public GameObject w;
    public GameObject s;
    public GameObject links;
    public GameObject rechts;
    public GameObject EmmyR;
    public GameObject EmmyF;
    public GameObject TotoR;
    public GameObject TotoF;
    public GameObject tutorial;
    public GameObject t2;
    public GameObject Anzeige;
    public GameObject Story;
    public moveEmmy EmmyS;
    public moveToto TotoS;
    private AudioSource Source;
    public AudioClip talk;





    private void Start()
    {
        Source = GetComponent<AudioSource>();
        Anzeige.SetActive(false);
        t2.SetActive(false);
        tutorial.SetActive(false);
        Klicks = 1;
        Herzen.SetActive(false);
        Lifescript.SetActive(false);
        Kristalle.SetActive(false);
        w.SetActive(false);
        s.SetActive(false);
        links.SetActive(false);
        rechts.SetActive(false);
        TotoF.SetActive(false);
        EmmyF.SetActive(false);
        W = "[W]";
        S = "[S]";
        Links = "[<]";
        Rechts = "[>]";
        Geschichte = "[SPACE]";
        sprechen();
    }


    public void sprechen()
    {
        Source.clip = talk;
        Source.Play();
    }



    public void Update()
    {
        
        DialogGeschichte.text = Geschichte;
        DialogNico.text = Nico;
        DialogToto.text = Toto;
        DialogEmmy.text= Emmy;
        WDia.text = W;
        SDia.text = S;
        DiaL.text = Links;
        DiaR.text = Rechts;
        
        Geschichte = "[SPACE]";
        
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Klicks += 1;
            sprechen();
        }
        if (Input.GetKeyDown(KeyCode.W) && Klicks>=16)
        {
            W = "";
            w.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.S) && Klicks >= 16)
        {
            S = "";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Klicks >= 16)
        {
            Links = "";
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && Klicks >= 16)
        {
            Rechts = "";
        }
        
        if (S == "" && W == "" && Links == "" && Rechts == "")
        {
            tutorial.SetActive(true);          
        }
        switch (Klicks)
        {
            case 1:
                Nico = "Menschen?";
                break; 
            
            case 2:
                Nico = "Aber wie kann dass nur sein?";
                
                break;

            case 3:
                Nico = "Schließlich dürftet ihr nicht hier sein!";
                break;

            case 4:
                Emmy = "...?";
                Nico = "";
                break;

            case 5:
                Emmy = "Kann es sein, dass wir kleiner geworden sind, Toto?";
                break;
            
            case 6:
                Emmy = "";
               Toto = "Das kannst du doch gar nicht beurteilen";
                break;
            case 7:
                Toto = "da du doch schon immer klein warst, Emmy!";
                break;
                
            case 8:
                Toto = "";
                Nico = "Leider ist eure Größe nicht euer Hauptproblem";
                break;
            
            case 9:
                Nico = " Schließlich scheint es so, als könnte Toto sich nur mit den [<]|[>] bewegen";
                break;
                
            case 10:
                Nico = "während Emmy sich nur mit [W]|[S] bewegen kann!";
                break;
            
            case 11:
                Nico = "";
                Emmy = "...?";
                Toto = "...?";
                break;
            
            case 12:
                Toto = "";
                Emmy = "";
                Nico = "Eure Bewegung ist eingeschränkt";
                break;
            
            case 13:
                Nico = "Toto kann sich nur nach links und rechts bewegen";
                break;
            
            case 14:
                Nico = "Bei Emmy ist es anders";
                break;
            
            case 15:
                Nico = "da sie sich nur nach oben und unten bewegen kann";
                break;
            
            case 16:
                Nico = "Probiert es aus!";
                
                break;
            
            case 17:
                Nico = "";
                Story.SetActive(false);
                Blackscreen.SetActive(false);
                w.SetActive(true);
                s.SetActive(true);
                links.SetActive(true);
                rechts.SetActive(true);
                TotoF.SetActive(true);
                EmmyF.SetActive(true);
                TotoR.SetActive(false);
                EmmyR.SetActive(false);
                
                break;
            default:
                break;
        }
    }
}
