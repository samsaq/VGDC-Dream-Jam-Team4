using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaze : MonoBehaviour
{
    private float rotationLeft = 0;
    private float rotationRight = 0;
    public float rotationSpeed = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && rotationLeft < rotationSpeed*10) {
            rotationLeft+=rotationSpeed;
            rotationRight = 0;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && rotationRight < rotationSpeed*10) { 
            rotationRight+=rotationSpeed;
            rotationLeft = 0;
        }
        this.transform.Rotate(0, 0, rotationLeft*Time.deltaTime);
        this.transform.Rotate(0, 0, -rotationRight*Time.deltaTime);


    }
}
