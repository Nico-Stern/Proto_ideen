using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public moveToto totom;
    public moveEmmy emmym;
    public GameObject TD;
    public GameObject ED;
    public static int Lifepoint = 6;

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {   totom.reset();
            emmym.reset();
            ED.transform.position = new Vector3(700, 500);
            TD.transform.position = new Vector3(1200, 500);
            Lifepoint -=1;
            print(Lifepoint);
        }
    }
}
