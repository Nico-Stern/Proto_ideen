using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial2 : MonoBehaviour
{
    public Text DialogEmmy;
    public Text DialogToto;
    public Text DialogNico;
    public Text DialogGeschichte;
    public string Geschichte;
    public string Emmy;
    public string Nico;
    public string Toto;
    public int tap = 0;
    public GameObject Herzen;
    public GameObject Lifescript;
    public GameObject Nicogeist;
    public GameObject story;
    public moveEmmy EmmyS;
    public moveToto TotoS;

    public void Update()
    {
        DialogGeschichte.text = Geschichte;
        DialogNico.text = Nico;
        DialogToto.text = Toto;
        DialogEmmy.text = Emmy;
        Geschichte = "[SPACE]";
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            tap += 1;
        }

        switch(tap )
        {
            case 1:
                EmmyS.down = 0;
                EmmyS.up = 0;
                TotoS.left = 0;
                TotoS.right = 0;
                Nicogeist.SetActive(true);
                story.SetActive(true);
                Nico = "Falls ihr mit eurer Mechanik nicht weiter kommen solltet";
                break;
            case 2:
                Nico = "werde ich euch zur Hilfe kommen";
                break; 
            case 3:
                Nico = "indem ihr [Leertaste] verwendet";
                break;
            case 4:
                Nico = "Damit bringe ich euch zurück in die Mitte";
                break;
            case 5:
                Nico = "Doch seid gewarnt";
                break;
                case 6:
                    Nico = "Sobald ihr mich ruft, verschwindet die Hälfte einer euer Herzen";
                    break;
                
            case 7:
                
                Nico = "Also seid vorsichtig mit euren Wünschen";
                break;
            case 8:
                EmmyS.down = 1;
                EmmyS.up = 1;
                TotoS.left = 1;
                TotoS.right = 1;
                Nico = "";
                story.SetActive(false);
                Nicogeist.SetActive(false);
                Lifescript.SetActive(true);
                Herzen.SetActive(true);
                break;
        }
    }
}
