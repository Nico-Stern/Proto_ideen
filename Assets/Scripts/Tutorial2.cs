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

    public void Update()
    {
        DialogGeschichte.text = Geschichte;
        DialogNico.text = Nico;
        DialogToto.text = Toto;
        DialogEmmy.text = Emmy;
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            tap += 1;
        }

        switch(tap )
        {
            case 1:
                Nicogeist.SetActive(true);
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
                Nico = "da dieser euch die Hälfte eines Herzen entnimmt";
                break;
            case 6:
                Nico = "";
                Nicogeist.SetActive(false);
                Lifescript.SetActive(true);
                Herzen.SetActive(true);
                break;
        }
    }
}
