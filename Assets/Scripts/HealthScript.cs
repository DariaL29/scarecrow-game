using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
  
    public float rotSpeed;
    public GameObject cube;


    public GameObject heart;



    public float health = 10;

    

    // Start is called before the first frame update
    void Start()
    {
       

    }
    // Update is called once per frame
    void Update()
    {

        OrbitAround();

    }

    void OrbitAround()
    {


        transform.RotateAround(cube.transform.position, Vector3.up, rotSpeed * Time.deltaTime);
        Debug.LogError("HEARTrotating");

    }

   


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            healthController.currentHealth = (healthController.currentHealth + health);
            Debug.LogError("+HEALTH");
            Destroy(gameObject);
        }
    }
}
