using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text DialogEmmy;
    public Text DialogToto;
    public Text DialogNico;
    public Text DialogGeschichte;
    public string Geschichte;
    public string Emmy;
    public string Nico;
    public string Toto;
    public GameObject Herzen;
    public GameObject Lifescript;
    public GameObject Kristalle;
    public GameObject Nicogeist;
    public int tap = 1;
    public GameObject dialog;
    public GameObject t2;
    public Itemzaehler zaehler;
    public GameObject Anzeige;

    private void Start()
    {
        print("hi");
    }

    public void Update()
    {
        DialogGeschichte.text = Geschichte;
        DialogNico.text = Nico;
        DialogToto.text = Toto;
        DialogEmmy.text = Emmy;
        if (zaehler.Kristalle >= 2)
        {
            t2.SetActive(true);
        }
    
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            tap += 1;
        }

        switch (tap)
        {
            case 1:
                Nico = "Gut so!";
                break;
            case 2:
                Nico = "Mit dieser Mechanik müsst ihr euch unterstützen und aus dem Haus fliehen!";
                break;
            case 3:
                Nico = "";
                Emmy = "Müssen wir auf irgendetwas achten?";
                break;
            case 4:
                Emmy = "";
                Nico = "Ja. Alle Türen des Hauses sind verschlossen";
                break;
            case 5:
                Nico = "Ihr müsst die einzelne Kristallsplitter sammeln und diese zu einem ganzen fügen";
                break;
            case 6:
                Nico = "Probiert es aus!";
                Kristalle.SetActive(true);
                Anzeige.SetActive(true);
                break;
            case 7:
                Nico = "";
                break;
            default:
                Nico = "";
                break;
        }
      
    }
}
