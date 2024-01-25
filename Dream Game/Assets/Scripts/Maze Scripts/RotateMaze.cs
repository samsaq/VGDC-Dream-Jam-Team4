using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaze : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) { 
            this.transform.Rotate(0, 0, 5f);
        }
            
        else if (Input.GetKeyDown(KeyCode.DownArrow)) { 
            this.transform.Rotate(0, 0, -5f);
        }

        
    }
}
