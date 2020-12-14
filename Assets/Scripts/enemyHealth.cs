using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public Slider healthSlider;


    bool destroyTop;
    bool destroyMiddle;
    bool destroyDown;

    public float maxHealth;

    public float currentHealthEnemy;

    public float damage = 10;

    


    Vector3 direction;
    //public GameObject target;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {

        currentHealthEnemy = maxHealth;
        healthSlider.maxValue = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        //healthbar facing camera
        healthSlider.transform.rotation = Camera.main.transform.rotation;

        healthSlider.value = currentHealthEnemy;

        //taking health of an enemy while its hit by laser gradually 
      //  StartCoroutine(WaitForSeconds());

        //if health 0 - destroy object
        if (currentHealthEnemy == 0)
        {
            Invoke("spawn", 1.0f);         
            Invoke("DestroyGameObject", 1f);
            Debug.LogError("DESTROY");

            
        }

       

    }


    // takes damage every 3 seconds if laser is hitting
   /* IEnumerator WaitForSeconds()
    {
       if (MainPlayerController.hit == true )
        
            currentHealthEnemy = currentHealthEnemy - damage;
            yield return new WaitForSeconds(3f);
            currentHealthEnemy = currentHealthEnemy - damage;
            StartCoroutine(WaitForSeconds());
            Debug.LogError("DAMAGE TAKEN");
        
    }*/


    void DestroyGameObject()
    {
        Destroy(enemy);
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.transform.gameObject.tag == "collider")
        {
            currentHealthEnemy = currentHealthEnemy - damage;
            Debug.LogError("DAMAGE TAKEN");
        }
    }

  
    void spawn()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }



}
