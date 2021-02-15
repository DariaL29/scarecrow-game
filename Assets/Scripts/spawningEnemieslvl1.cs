using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawningEnemieslvl1 : MonoBehaviour
{
    public int eCount = 0;
    [SerializeField]
    public int maxcount;
    bool started;
    


    public Button continueButton;

    public GameObject enemyTop;
    public GameObject enemyMiddle;
    public GameObject enemyDown;

    public GameObject heart;

    [SerializeField]
    private Transform spawnPointTop;


    [SerializeField]
    private Transform spawnPointMiddle;


    [SerializeField]
    private Transform spawnPointDown;

    // Start is called before the first frame update
    void Start()
    {
        started = false;
        continueButton.onClick.AddListener(TaskOnClick);
        enemyDown.transform.rotation = Camera.main.transform.rotation;
        enemyTop.transform.rotation = Camera.main.transform.rotation;
       
        InvokeRepeating("SpawnHeart", 8.0f, 12f);
    }

    // Update is called once per frame
    void Update()
    {
       


        // randomizing spawning point of new enemies
        if (GameObject.FindGameObjectsWithTag("enemy").Length < 2 && eCount < maxcount && started == true )
        {

            if (Random.Range(1,3) == 1)
            {
                Instantiate(enemyDown, spawnPointDown.position, transform.rotation);
                eCount++;
            }

            if (Random.Range(1, 3) == 2)
            {
                Instantiate(enemyMiddle, spawnPointMiddle.position, transform.rotation);
                eCount++;
            }


            if (Random.Range(1, 3) == 3)
            {
                Instantiate(enemyTop, spawnPointTop.position, transform.rotation);
                eCount++;
            }
        }

       


       


    }

    

    void TaskOnClick()
    {
        Invoke("Spawner", 5.0f);
        Invoke("FirstRound", 8.0f);
     
    }



    void Spawner()
        {

        Instantiate(enemyDown, spawnPointDown.position, transform.rotation);
        Instantiate(enemyMiddle, spawnPointMiddle.position, transform.rotation);
        Instantiate(enemyTop, spawnPointTop.position, transform.rotation);
       
        }

   void FirstRound()
    {
        started = true;
    }


     void SpawnHeart()
    {
  
       

        if (GameObject.FindGameObjectsWithTag("health").Length == 0 && eCount != maxcount)
        {   
                Instantiate(heart, spawnPointMiddle.position, transform.rotation);

        }

    }





}
