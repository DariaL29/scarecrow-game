using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headcontroller : MonoBehaviour
{
   
    public GameObject head;
    public GameObject body;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (/*!Input.GetKey(KeyCode.LeftArrow) && (!Input.GetKey(KeyCode.RightArrow)) &&*/ (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            //transform.Rotate(eulers:rotationDown * (rotationSpeed * Time.deltaTime));
            head.transform.Rotate(0, 0, 30, Space.Self);
        }
        //turns up
        if (/*!Input.GetKey(KeyCode.LeftArrow) && (!Input.GetKey(KeyCode.RightArrow)) &&*/ (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            //transform.Rotate(eulers: rotationUp * (rotationSpeed * Time.deltaTime));
            head.transform.Rotate(0, 0, -30, Space.Self);
        }

        //get back to original position when releasing these buttons
        if ((Input.GetKeyUp(KeyCode.DownArrow)) || (Input.GetKeyUp(KeyCode.UpArrow)))
        {
            //transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);
            // transform.rotation = Quaternion.Euler(0, transform.rotation.y, transform.rotation.z);
            //head.transform.rotation.y = body.transform.rotation.y;
            Align();



        }
 
    }
    private void Align()
    {
        Vector3 direction = body.transform.position - head.transform.position;
        // Change child.forward to child.up if you want the up vectors to "look at" the other child object
        Quaternion rotation = Quaternion.FromToRotation(head.transform.forward, direction);
        transform.rotation = rotation * transform.rotation;
        Vector3 eulerRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);
    }





}



