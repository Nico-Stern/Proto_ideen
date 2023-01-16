using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Move2D TotoM;
    public player2 EmmyM;
    public static int Lifepoint = 6;

    private void Start()
    {
        
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
           /* TotoM.reset ();
            EmmyM.reset ();
            Lifepoint -=1;
            print(Lifepoint);
            */
        }
    }
}
