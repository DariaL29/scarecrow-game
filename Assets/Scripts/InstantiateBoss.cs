using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBoss : MonoBehaviour
{
    bool bossAlreadyThere = false;
    public GameObject boss;
    public Rigidbody rbody;

    [SerializeField]
    private Transform spawnPointTop;


    [SerializeField]
    private Transform spawnPointMiddle;


    [SerializeField]
    private Transform spawnPointDown;


    public GameObject heart;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnHeart", 8.0f, 12f);
    }

    // Update is called once per frame
    void Update()
    {
        // StartCoroutine(AccelerateBoss());


        if (GameObject.Find("SequenceController").GetComponent<setActive>().boss == true && bossAlreadyThere == false)
        {
            Invoke("SpawnBoss", 2.0f);
            bossAlreadyThere = true;
        }


    }
   

    void SpawnBoss()
    {
        Instantiate(boss, spawnPointDown.position, transform.rotation);
    }


        void SpawnHeart()
        {



            if (GameObject.FindGameObjectsWithTag("health").Length == 0 && bossAlreadyThere == true )
            {
                Instantiate(heart, spawnPointMiddle.position, transform.rotation);

            }

        }


    }
