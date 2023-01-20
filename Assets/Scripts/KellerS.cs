using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class KellerS : MonoBehaviour
{
    public Leben life;
    
    public int AufLebenResten = 6;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Leben.Lebenanzahl = AufLebenResten;
            
            SceneManager.LoadScene("Keller");
            
        }
    } 
}
