using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit2 : MonoBehaviour
{

    //distance between player and rotating object

    public GameObject cube;
    public float rotSpeed2;
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
        transform.RotateAround(cube.transform.position, Vector3.up, -rotSpeed2 * Time.deltaTime);
    }











}
