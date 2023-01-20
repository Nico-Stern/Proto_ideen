using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life2 : MonoBehaviour
{
    public toto1move totom;
    public Emmy1move emmym;
    public TotoDia TD;
    public EmmyDia ED;
    public int Lifepoint = 6;
    public Leben LZ;
    
   

    public void Update()
    {
    Lifepoint= Leben.Lebenanzahl;
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Leben.Lebenanzahl--;
            totom.reset();
            emmym.reset();
            ED.transform.position = new Vector3(700, 500);
            TD.transform.position = new Vector3(1200, 500);            
            print(Lifepoint);
            
        }
    }
}
