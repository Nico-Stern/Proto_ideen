using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public moveToto totom;
    public moveEmmy emmym;
    public static int Lifepoint = 6;

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {   totom.reset();
            emmym.reset();
            Lifepoint -=1;
            print(Lifepoint);
        }
    }
}
