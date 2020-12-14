using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class BossBehavior : MonoBehaviour
{

    public GameObject cube;
    
    private Vector3 middlePosition = new Vector3(8, 0 , 0);
    private Vector3 upPosition = new Vector3(-8, 4, 0);
    private Vector3 downPosition = new Vector3(8, -4, 0);
    private Vector3 attackPosition = new Vector3(0, 0, 0);


    // Start is called before the first frame update
    void Start()
    {
        transform.position = middlePosition;
        
    }

    void Update()
    {
        float rotSpeedBoss = Random.Range(45f, 150f);
        
        int random = Random.Range(1, 7);
        //Debug.Log(random);
        int randomAttack = Random.Range(0, 20);

     transform.RotateAround(cube.transform.position, Vector3.up, rotSpeedBoss * Time.deltaTime);


        if (random == 1 &&  transform.position.y == 0)
        {
            //Vector3 changedPosition1 = upPosition;
            transform.Translate(upPosition * Time.deltaTime);
           
            //gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

        if (random == 2 &&  transform.position.y == -4 )
        {
            //Vector3 changedPosition2 = middlePosition;
            transform.Translate(middlePosition * Time.deltaTime);
        }
      
        if (random == 3 && transform.position.y == 4)
        {

            //Vector3 changedPosition2 = downPosition;
            
            transform.Translate(downPosition * Time.deltaTime);
        }

        

    }
   
    
}




