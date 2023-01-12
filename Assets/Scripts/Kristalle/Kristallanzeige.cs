using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kristallanzeige : MonoBehaviour
{
    public Itemzaehler zaehler;
    public int Reihe = 0;
    public Renderer renderer;
    void Start()
    {
     renderer= GetComponent<Renderer>();
        renderer.enabled = false;
    }

    void Update()
    {
        if(Reihe== zaehler.Kristalle)
        {
            renderer.enabled = true;
        }
    }
}
