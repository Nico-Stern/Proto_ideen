using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public Life life;
    public float horizontal;
    public float Speed = 5f;

    public float linkeGrenze = -8.5f;
    public float rechteGrenze = 8.5f;
    public float obereGrenze = 4.5f;
    public float untereGrenze = -4.5f;

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
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            reset();
        }

    }

    void reset()
    {
        Vector3 Resetposition = new Vector3(2, 0, 0);
        transform.position = Resetposition;

    }
}
