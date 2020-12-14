using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    //distance between player and rotating object
    
    public GameObject cube;
    public float rotSpeed;
    /* public float xSpread;
     public float zSpread;
     public Transform centerPoint;

     public bool rotateClockwise;
     float timer = 0; */




    void Start()
    {
        
    }

   
    void Update()
    {
        OrbitAround();

    }
    void OrbitAround()
    {
        transform.RotateAround(cube.transform.position, Vector3.up, rotSpeed * Time.deltaTime );
    }











}




