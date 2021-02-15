using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealth : MonoBehaviour
{
    public Slider healthSlider;


    bool destroyTop;
    bool destroyMiddle;
    bool destroyDown;

    public float maxHealth;

    public float currentHealthEnemy;

    public float damage = 10;

    public bool enemyDestroyed;


    Vector3 direction;
    //public GameObject target;
    public GameObject enemy;

    // Start is called before the first frame update
    private void Awake()
    {

        currentHealthEnemy = maxHealth;
        healthSlider.maxValue = maxHealth;
    }



    void Start()
    {

        enemyDestroyed = false;
    }

    // Update is called once per frame
    void Update()
    {
        //healthbar facing camera
        healthSlider.transform.rotation = Camera.main.transform.rotation;

        healthSlider.value = currentHealthEnemy;

      
        //if health 0 - destroy object
        if (currentHealthEnemy == 0)
        {
        
            Invoke("DestroyGameObject", 1f);
            Debug.LogError("DESTROY");
            

        }

       

    }


  

    void DestroyGameObject()
    {
        Destroy(enemy);
        enemyDestroyed = true;      
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
