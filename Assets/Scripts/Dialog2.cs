using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog2 : MonoBehaviour
{
    public Text DialogEmmy;
    public Text DialogToto;
    public Text DialogNico;
    public Text DialogGeschichte;
    public string Geschichte;
    public string Emmy;
    public string Nico;
    public string Toto;
    public static int Klicks = 0;
    public GameObject Herzen;
    public GameObject Lifescript;
    public GameObject Kristalle;
    public GameObject Blackscreen;
    public GameObject w;
    public GameObject s;
    public GameObject links;
    public GameObject rechts;

    private void Start()
    {
        Klicks = 0;
        Herzen.SetActive(false);
        Lifescript.SetActive(false);
        Kristalle.SetActive(false);
        w.SetActive(false);
        s.SetActive(false);
        links.SetActive(false);
        rechts.SetActive(false);
    }

    private void Update()
    {
        DialogGeschichte.text = Geschichte;
        DialogNico.text = Nico;
        DialogToto.text = Toto;
        DialogEmmy.text= Emmy;
        Geschichte = "";
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Klicks += 1;
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
                break;
                
            
            
            
            
                
                
        }
    }
}
