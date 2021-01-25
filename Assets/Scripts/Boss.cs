using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLVL1 : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    float fireRate;
    float nextFire;

    [SerializeField]
    GameObject boss;



    //rotation around
    public GameObject cube;
    public float rotSpeed2;
    public float rotSpeedStop = 0;
    Vector3 notRotating = new Vector3(0, 0, 0);
    public Rigidbody rb;
   


    void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;


       // StartCoroutine(DoEveryFiveSeconds());

    }


    void Update()
    {

        if (MainPlayerController.hit == true)
        {
            OrbitAroundStop();
        }
        else if (MainPlayerController.hit == false )
        {
            OrbitAround();
        }
       
        

        CheckIfTimeToFire();
    }
    void OrbitAround()
    {


        transform.RotateAround(cube.transform.position, Vector3.up, rotSpeed2 * Time.deltaTime);
        Debug.Log("rotating");

    }
    void OrbitAroundStop()
    {


        transform.RotateAround(cube.transform.position, Vector3.up, rotSpeedStop);
        Debug.Log("rotating");

    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

    


  


}
