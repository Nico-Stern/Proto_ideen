using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject KItem;
    public int Spawnzahl = 0;
    
    
    void Update()
    {
        for(int i=0; i<=Spawnzahl; )
        {
            transform.position = Random.insideUnitSphere;
            Instantiate(KItem, transform.position, Quaternion.identity);
            i++;
        }
    }
    
}
