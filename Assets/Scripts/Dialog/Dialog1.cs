using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialog1 : MonoBehaviour
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
    private AudioSource Source;
    public AudioClip talk;


    private void Start()
    {
        Klicks = 0;
        Source = GetComponent<AudioSource>();
    }
    public void sprechen()
    {
        Source.clip = talk;
        Source.Play();
    }

    void Update()
    {
        DialogGeschichte.text = Geschichte;
        DialogNico.text = Nico;
        DialogToto.text = Toto;
        DialogEmmy.text= Emmy;
        Geschichte = "[SPACE]";
        Toto = "Autsch! Mein Kopf tut weh ";

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Klicks += 1;
            
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && Klicks <= 2){
            sprechen();
        }

            switch (Klicks)
        {


            case 1:
                Toto = "...? ";
                
                break;

            case 2:
                
                Toto = "Wo sind denn wir gelandet?";
               
                break;

            case 3:
                Toto = "";
                
                SceneManager.LoadScene("Lvl.1");
                Herzen.SetActive(false);
                
                break;

            case 4:

                break;
                
        }
    }
}
