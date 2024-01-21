using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaze : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { 
            this.transform.Rotate(0, 0, 2f);
        }
            
        else if (Input.GetKeyDown(KeyCode.RightArrow)) { 
            this.transform.Rotate(0, 0, -2f);
        }

        
    }
}
