using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class KellerS : MonoBehaviour
{
    public Life life;
    public int AufLebenResten = 6;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Life.Lifepoint = AufLebenResten;
            SceneManager.LoadScene("Keller");
            
        }
    } 
}
