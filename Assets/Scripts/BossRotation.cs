using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRotation : MonoBehaviour
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
   // public float rotSpeedFast;
    Vector3 notRotating = new Vector3(0, 0, 0);
    public Rigidbody rb;
   


    void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;


        StartCoroutine(AccelerateBoss());

    }


    void Update()
    {

       //StartCoroutine(AccelerateBoss());


       // InvokeRepeating("Accelerate", 2.0f, 4.0f);


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







    /* void Accelerate()
     {
         IEnumerator Accelerate()
         {
             rotSpeed2 = rotSpeed2 + 5;
             yield return new WaitForSeconds(4);
             rotSpeed2 = rotSpeed2 - 5;
             Debug.LogError("Speed Up");

         }


     }*/

   IEnumerator AccelerateBoss()
    {
        {
            int i = 0;
            
            while (i < 10)
            {
               
                // Count to Ten
                rotSpeed2 = rotSpeed2 + 20;
                i++;
                yield return new WaitForSeconds(3);
                Debug.LogError("accelerating +2");
            }

           /* while (i > 0)
            {
                // Count back to Zero
                i--;
                yield return null;
            }*/

            // All done!
        }

    }
   
}
