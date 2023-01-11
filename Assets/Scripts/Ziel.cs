using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziel : MonoBehaviour
{
    public GameObject OpenS;
    public GameObject closedS;
    public Itemzaehler zaehler;
    public int Zielkristale = 0;
    public int Kristalle;
    public int ziel;
    
    
    
    
    public void Update()
    {
        Kristalle = zaehler.Kristalle;
        if (Kristalle == ziel)
        {
            closedS.SetActive(false);
            OpenS.SetActive(true);
        }
        
    }
}
