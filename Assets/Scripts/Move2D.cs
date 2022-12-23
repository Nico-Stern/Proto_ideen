using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float horizontal;    
    public float Speed = 5f;
    
    public float linkeGrenze = -8.5f;
    public float rechteGrenze = 8.5f;
    public float obereGrenze = 4.5f;
    public float untereGrenze = -4.5f;
    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 moveH = horizontal * Vector2.right * Speed * Time.deltaTime;
        transform.Translate(moveH);

        Vector2 positionV = transform.position;
        positionV.y = Mathf.Clamp(positionV.y, untereGrenze, obereGrenze);
        transform.position = positionV;

        Vector2 positionH = transform.position;
        positionH.x = Mathf.Clamp(positionH.x, linkeGrenze, rechteGrenze);
        transform.position = positionH;
    }
}
