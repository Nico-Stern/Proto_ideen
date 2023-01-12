using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tuer2 : MonoBehaviour
{ 
private int nextscene;
private int lastscene;
// Start is called before the first frame update
void Start()
{
    nextscene = SceneManager.GetActiveScene().buildIndex + 1;
    lastscene= SceneManager.GetActiveScene().buildIndex - 1;
}

// Update is called once per frame
void Update()
{

}
private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        SceneManager.LoadScene("Lvl.1");
    }

}
}
