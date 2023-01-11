using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herz : MonoBehaviour
{
    public int HP = 100;
    public Life life;
    public int Leben;
    
    

    public void Update()
    {
        Leben = Life.Lifepoint;
        if(HP==Leben)
        {
            gameObject.SetActive(false);
        }
    }
}

