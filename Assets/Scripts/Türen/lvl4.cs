using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl4 : MonoBehaviour
{
     public Itemzaehler zaehler;
        public Ziel ziel;
        public int Kristalle;
        public int Ziel;
        void Start()
        {
            gameObject.SetActive(false);
            Kristalle = zaehler.Kristalle;
            Ziel = ziel.Zielkristale;
        }
    
        public void Update()
        {
            Kristalle = zaehler.Kristalle;
            Ziel = ziel.Zielkristale;
    
    
    
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player1") || (collision.gameObject.CompareTag("Player2")))
            {
                SceneManager.LoadScene("Lvl.4");
            }
        }
        
    }

