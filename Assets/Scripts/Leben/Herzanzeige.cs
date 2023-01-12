using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herzanzeige : MonoBehaviour
{
    public Life life;
    public Herz HP;
    public Renderer renderer;
    public static int Leben = 0;
    public static int HPP = 0;
    private Color FColor;
    public Color visible = Color.clear;
    void Start()
    {
        renderer= GetComponent<Renderer>();
        renderer.enabled = true;
    }

    public void Update()
    {
        int Leben = Life.Lifepoint;
        int HPP = HP.HP;
        
    }
}
