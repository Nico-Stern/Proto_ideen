using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Druckoffnen : MonoBehaviour
{
    public DruckNormal Dnormal;
    public GameObject schließen;
   
    void Update()
    {
        if (Dnormal.Triggernormal >= 1)
        {
            schließen.SetActive(true);
        }

        if (Dnormal.Triggernormal == 0)
        {
            schließen.SetActive(false);
        }
    }
}
