using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuer : MonoBehaviour
{
    private int nextscene;
    void Start()
    {
        nextscene = SceneManager.GetActiveScene().buildIndex + 1;
        
    }
    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextscene);
        }

    }
}
