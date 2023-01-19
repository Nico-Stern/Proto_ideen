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
                Nico = "Falls ihr mit eurer Mechanik nicht weiterkommt";
                break;
            case 2:
                Nico = "benutzt diesen Zauberspruch [Leertaste]";
                break; 
            case 3:
                Nico = "Dieser bringt euch wieder in die Mitte";
                break;
            case 4:
                Nico = "Doch seid vorsichtig!";
                break;
            case 5:
                EmmyS.down = 1;
                EmmyS.up = 1;
                TotoS.left = 1;
                TotoS.right = 1;
                Nico = "da dieser euch die Hälfte eines Herzen entnimmt";
                break;
            case 6:
                Nico = "";
                story.SetActive(false);
                Nicogeist.SetActive(false);
                Lifescript.SetActive(true);
                Herzen.SetActive(true);
                break;
        }
    }
}
