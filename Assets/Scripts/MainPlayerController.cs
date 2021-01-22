using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerController : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    //private float rotationResetSpeed;

    // public Quaternion originalRotationValue;

    public LayerMask mask;

    public GameObject enemy;
    private Vector3 rotationDown = new Vector3(1, 0, 0);
    private Vector3 rotationUp = new Vector3(-1, 0, 0);
    private Vector3 origin = new Vector3(0, -0.02f, 0.68f);
    public static bool hit = false;





    void Start()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
      


        if (Input.GetKey(KeyCode.Space) && laserRecharge.currentCharge > 0)
        {
            Shoot();
        }
        else
        hit = false;



        // if i have not pressed up or down - turn left
        if  (!Input.GetKey(KeyCode.UpArrow) && (!Input.GetKey(KeyCode.DownArrow)) &&  (Input.GetKey(KeyCode.LeftArrow)))
        {

            transform.Rotate(eulers: Vector3.up * (rotationSpeed * Time.deltaTime));

        }
        // if i have not pressed up and down - rotate
        if (/*!Input.GetKey(KeyCode.UpArrow) && (!Input.GetKey(KeyCode.DownArrow))*//* && */ (Input.GetKey(KeyCode.RightArrow)))
        {

            transform.Rotate(eulers: Vector3.down * (rotationSpeed * Time.deltaTime));
        }
     

    }


    void Shoot()
    {


        Ray ray = new Ray(origin, transform.forward );
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 15, mask))
        {
            Debug.Log("I hit enemy");
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            hit = true;
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 15, Color.green);
           
        }
       
       
        

    }

   
   

}




