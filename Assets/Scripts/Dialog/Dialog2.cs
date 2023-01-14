using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
    public int Klicks = 0;
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



    private void Start()
    {
        Anzeige.SetActive(false);
        t2.SetActive(false);
        tutorial.SetActive(false);
        Klicks = 0;
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
        
        Geschichte = "";
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Klicks += 1;
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
                Nico = "Was macht ihr Menschen hier!?";
                break; 
            
            case 2:
                Nico = "Eigentlich dürftet ihr hier gar nicht sein.";
                
                break;

            case 3:
                Nico = "Es ist viel zugefählich für euch";
                break;

            case 4:
                Emmy = "Wir wollen auch hier gar nicht sein!";
                Nico = "";
                break;

            case 5:
                Emmy = "Sonst bekommen wir ärger von unserer Mutter";
                break;
            
            case 6:
                Emmy = "";
                Nico = "Vergisst euer Mutter Problem!";
                break;
                
            case 7:
                Nico = "Schließlich scheint es so als...";
                break;
            
            case 8:
                Nico = "Könnte Toto sich nur mit den [<][>] Pfeiltasten bewegen";
                break;
                
            case 9:
                Nico = "Während Emmy sich nur mit [W][S] bewegen kann!";
                break;
            
            case 10:
                Nico = "";
                Emmy = "...?";
                Toto = "...?";
                break;
            
            case 11:
                Toto = "";
                Emmy = "";
                Nico = "Ihr wurdet verflucht!!!";
                break;
            
            case 12:
                Nico = "Toto kann sich nur nach links und rechts bewegen";
                break;
            
            case 13:
                Nico = "Bei Emmy ist es anders";
                break;
            
            case 14:
                Nico = "Emmy kann sich nur nach oben und unten bewegen";
                break;
            
            case 15:
                Nico = "probiert es mal aus";
                
                break;
            
            case 16:
                Nico = "";
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
