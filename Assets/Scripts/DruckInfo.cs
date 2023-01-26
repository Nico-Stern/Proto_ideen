using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DruckInfo : MonoBehaviour
{
    public DruckNormal Dnormal;
    public float xn = 0f;
    public float yn = 0f;
    public float x = 0f;
    public float y = 0f;
    
   public void Update()
    {
        if (Dnormal.Triggernormal >= 1)
        {
            transform.position = new Vector3(x, y);
        }

        if (Dnormal.Triggernormal == 0)
        {
            transform.position = new Vector3(xn, yn);
        }
    }
}
