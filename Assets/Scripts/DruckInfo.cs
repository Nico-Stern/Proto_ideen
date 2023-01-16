using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DruckInfo : MonoBehaviour
{
    public DruckNormal Dnormal;

    public void Start()
    {
        
    }

   public void Update()
    {
        if (Dnormal.Triggernormal >= 1)
        {
            //print("da");
        }

        if (Dnormal.Triggernormal == 0)
        {
            //print("raus");
        }
    }
}
