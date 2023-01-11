using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class KellerS : MonoBehaviour
{
    public Life life;
    public int AufLebenResten = 0;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Keller");
            Life.Lifepoint = AufLebenResten;
        }
    } 
}
