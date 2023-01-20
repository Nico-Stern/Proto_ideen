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
    public int Lifepoint = 6;
    public Leben AL;


    public void Update()
    {
        Lifepoint = Leben.Lebenanzahl;
        if (Input.GetKeyDown(KeyCode.Space) == true)
            
        {
            Leben.Lebenanzahl--;
           
            ED.transform.position = new Vector3(700, 500);
            TD.transform.position = new Vector3(1200, 500);          
            print(Lifepoint);
            totom.reset();
            emmym.reset();
            

        }
    }
}
