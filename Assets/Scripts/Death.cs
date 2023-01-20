using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Leben life;
    
    public int Lifepoints;
    void Start()
    {
        
    }
    public void Update()
    {
        Lifepoints = Leben.Lebenanzahl;
        if (Lifepoints == 0)
        {
            SceneManager.LoadScene("Death");
            
        }
        
    }
}
