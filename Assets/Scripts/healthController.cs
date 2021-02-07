 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthController : MonoBehaviour
{
    public Slider healthSlider;

    public float maxHealth;

    public static float currentHealth;

    public float health = 10;

    public GameObject heart;


    // Start is called before the first frame update
   
    
    
    
    
    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = currentHealth;
     
    }


    /* private void OnTriggerEnter(Collider collider)
     {
         if (collider.tag == "bulletr")
         {
             Debug.Log("bullet collision");
             currentHealth = (currentHealth - damage);
         }
     }
    */

}
