using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life2 : MonoBehaviour
{
    public toto1move totom;
    public Emmy1move emmym;
    public TotoDia TD;
    public EmmyDia ED;
    public static int Lifepoint = 6;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            totom.reset();
            emmym.reset();
            ED.reset();
            TD.reset();
            Lifepoint -= 1;
            print(Lifepoint);
        }
    }
}
