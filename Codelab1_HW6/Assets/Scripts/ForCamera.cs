using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Usage: put on your main camera
//purpose: demo some camera techniques, like a simple mouse look/ follow a target

public class ForCamera: MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        //simple mouse look. stubbing mode(what do you want to do then fill it in)
        
        //1. get mouse input?
        float horizontalMouseSpeed = Input.GetAxis("Mouse X");
        float verticalMouseSpeed = Input.GetAxis("Mouse Y");
        Debug.Log(horizontalMouseSpeed);// print to make sure it works

        //2. use mouse input to rotate camera
        transform.Rotate(0f, horizontalMouseSpeed, 0f);
        Camera.main.transform.Rotate(verticalMouseSpeed, 0f, 0f);
        
        //3. unroll the camera, we need to set it's Z angle to 0f, always?
        //transform.eulerAngles.z = 0f; //unity won't let you do it like this
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0f);
    }
}
