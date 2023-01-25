using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject Menu;
    public int Tabs = 1;
    
    void Start()
    {
        
    }
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Tabs++;
        }
        
    
        switch (Tabs)
        {
            case 1:
                Menu.SetActive(true);
                break;
            case 2:
                Menu.SetActive(false);
                Tabs = 0;
                break;
        }
        
    }
}
