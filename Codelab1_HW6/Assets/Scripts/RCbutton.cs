using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Intent: put this on an object (with a collider) to make it clickable
//Purpose:  shoot raycast based on mouse cursor to detect any collisions
public class RCbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //step 1: generate a ray variable
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //step2: Visualize the Raycast
        Debug.DrawRay(myRay.origin, myRay.direction * 1000f, Color.yellow);


        //step 3: intialize a raycast hit varrible
        //"raycastHit" is a type of varrible that has more info about what it
        RaycastHit myRayHitInfo = new RaycastHit();

        if (Input.GetMouseButtonDown(0))
        {

            //step 4: actually shoot raycast now!

            if (Physics.Raycast(myRay, out myRayHitInfo, 1000f))
            {
                //Step 5: do something with the raycast
                //Destroy(myRayHitInfo.collider.gameObject);

                myRayHitInfo.transform.Translate(0f, 1f, 0f);

                myRayHitInfo.transform.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);
            }
        }
    }

    void OnMouseDown()
    {
        Debug.Log("you clicked on me!");
        transform.Translate(0f,1f,0f);
    }
}
