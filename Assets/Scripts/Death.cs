using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Life life;
    public int Lifepoints;
    void Start()
    {
        
    }
    public void Update()
    {
        Lifepoints = Life.Lifepoint;
        if (Lifepoints == 0)
        {
            SceneManager.LoadScene("Death");
        }
    }
}
