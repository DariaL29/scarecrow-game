using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Vector3 attackPosition = new Vector3(0f, 0f, 0f);
    Vector3 originalPosition = new Vector3(8, 0, 0);
   

    void Start()
    {
       // StartCoroutine("WaitAndExecute");
        //Invoke("StopExecution", 25f);


    }

    /*void StopExecution()
    {
        StopCoroutine("WaitAndExecute");
    }*/

    
    
    
    
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided");
            transform.position = originalPosition;

        }

    }

    void Update()
    {
        int randomAttack = Random.Range(0, 100);

        if (randomAttack == 7)
        {
        
            transform.position = attackPosition;

        }
      
    }

   /* IEnumerator attackTime()
    {
        yield return new WaitForSeconds(Random.Range(2f, 7f));
        transform.position = attackPosition;
        {


            StartCoroutine("WaitAndExecute");

        }
    }*/
   


    




}
