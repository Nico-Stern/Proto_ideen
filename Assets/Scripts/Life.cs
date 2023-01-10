using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour

{
    public int Lifepoint = 12;
    public Text Lifetext;

    public void Update()
    {
        Lifetext.text = Lifepoint.ToString();
    }
}
