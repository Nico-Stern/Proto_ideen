using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class TotoDia : MonoBehaviour
{
    
    public EmmyDia Emmy;
    
    
    public void reset()
    {
        Vector3 Resetposition = new Vector3(1200, 500, 0);
        transform.position = Resetposition;
    }
    public void Up()
    {
        Vector2 positionw = Vector2.up *105;
        transform.Translate(positionw);

    }

    public void Down()
    {
        Vector2 positionS = Vector2.down * 105;
        transform.Translate(positionS);


    }

    public void Right()
    {
        Vector2 positionr = Vector2.right * 105;
        transform.Translate(positionr);
    }

    public void Left()
    {
        Vector2 positionr = Vector2.left * 105;
        transform.Translate(positionr);
    }
}
