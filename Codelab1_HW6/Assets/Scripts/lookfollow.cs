using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Usage: put this on a thing that looks at stuff
//Purpose: make the object look at a thing forever

public class lookfollow : MonoBehaviour
{

    public Transform lookTarget;
    
// Update is called once per frame
    void Update()
    {
        {
            if (lookTarget == null)
            {
                return;
            }

            //transform.LookAt(lookTarget);
            Vector3 foreward = lookTarget.position - transform.position; //line from A to B = B- A
            Quaternion targetRotation = Quaternion.LookRotation(lookTarget.position - transform.position);
            //change the rotation based on quaternions
            //transform.rotation=Quaternion.RotateTowards(transform.rotation, targetRotation, 30f*Time.deltaTime);
            //more organic feel 
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5f * Time.deltaTime);
        }
    }
}
