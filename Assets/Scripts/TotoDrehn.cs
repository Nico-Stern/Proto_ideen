using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotoDrehn : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            Quaternion Rotation = transform.rotation;
            Rotation.y = 180;
            Rotation.x = 0;
            Rotation.z = 0; 
            transform.rotation = Rotation;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            Quaternion Rotation = transform.rotation;
            Rotation.y = 0;
            Rotation.x = 0;
                Rotation.z = 0;
            transform.rotation = Rotation;
        }
    }
}
