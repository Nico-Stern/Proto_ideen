using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herz1 : MonoBehaviour
{
    public int HP = 100;
    public Life life;
    public int Leben;


    public void Start()
    {
        Leben = life.Lifepoint;
        
        if (HP >= Leben)
        {
            gameObject.SetActive(false);
        }
    }

    public void Update()
    {
        Leben = life.Lifepoint;

        if (HP == Leben)
        {
            gameObject.SetActive(false);
        }
    }
}
