using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 7f;
    Rigidbody rb;

    public GameObject target;
    Vector3 direction;

    public float damage = 10;
    public float damageBoss = 20;
    GameObject boss;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z);
        Destroy(gameObject, 3f);
        boss = GameObject.FindGameObjectWithTag("boss");
    }

    // Update is called once per frame
    void Update()
    {

    }


   private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            healthController.currentHealth = (healthController.currentHealth - damage);
            Debug.LogError("Hit");
            Destroy(gameObject);
        }
        else if (collider.tag == "Player" && boss.activeInHierarchy == true )
        {
            healthController.currentHealth = (healthController.currentHealth - damageBoss);
            Debug.LogError("Hit");
            Destroy(gameObject);
        }
    }
}