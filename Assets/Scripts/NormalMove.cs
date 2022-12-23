using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class NormalMove : MonoBehaviour
{
    public float horizontal;
    public float runspeed = 5f;
    public int Richtung = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 movement = horizontal * Vector2.right * runspeed * Time.deltaTime;
        transform.Translate(movement);

        

        
        
    }
}
