using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaze : MonoBehaviour
{
    private float rotation;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { 
            if (rotation < .5f) { rotation += .05f; }
        }
            
        else if (Input.GetKeyDown(KeyCode.RightArrow)) { 
            if (rotation > -.5f) { rotation -= .05f; }
        }

        this.transform.Rotate(0, 0, rotation);
    }
}
