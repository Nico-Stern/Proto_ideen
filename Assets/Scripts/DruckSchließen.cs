using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DruckSchließen : MonoBehaviour
{
    public DruckNormal Dnormal;
    public GameObject offen;
   
    void Update()
    {
        if (Dnormal.Triggernormal >= 1)
        {
            offen.SetActive(false);
        }

        if (Dnormal.Triggernormal == 0)
        {
            offen.SetActive(true);
        }
    }
}
