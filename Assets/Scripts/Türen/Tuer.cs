using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuer : MonoBehaviour
{
    private int nextscene;
    public Itemzaehler zaehler;
    public Ziel ziel;
    public int Kristalle;
    public int Ziel;
    void Start()
    {
        nextscene = SceneManager.GetActiveScene().buildIndex + 1;
        gameObject.SetActive(false);
        Kristalle = zaehler.Kristalle;
        Ziel = ziel.Zielkristale;
    }
    
   public void Update()
    {
        Kristalle = zaehler.Kristalle;
        Ziel = ziel.Zielkristale;
        if (Kristalle == Ziel)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Keller");
        }

    }
}
