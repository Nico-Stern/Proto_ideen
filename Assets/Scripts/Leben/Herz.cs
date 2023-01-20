using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herz : MonoBehaviour
{
    public int HP = 100;
    public Leben life;
    
    public int Le;


    public void Start()
    {
        Le = Leben.Lebenanzahl;
        
        if (HP >= Le)
        {
            gameObject.SetActive(false);
        }
    }
    public void Update()
    {
        Le = Leben.Lebenanzahl;
        if (HP==Le)
        {
            gameObject.SetActive(false);
        }
    }
}

