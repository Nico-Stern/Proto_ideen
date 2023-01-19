using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herz : MonoBehaviour
{
    public int HP = 100;
    public Life life;
    public Life2 Life2;
    public int Leben;


    public void Start()
    {
        Leben = Life.Lifepoint;
        Leben= Life2.Lifepoint;
        if (HP >= Leben)
        {
            gameObject.SetActive(false);
        }
    }
    public void Update()
    {
        Leben = Life.Lifepoint;
        Leben= Life2.Lifepoint;
        if(HP==Leben)
        {
            gameObject.SetActive(false);
        }
    }
}

