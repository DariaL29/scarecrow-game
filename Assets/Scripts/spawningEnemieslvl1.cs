using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawningEnemieslvl1 : MonoBehaviour
{
    int eCount = 0;
    [SerializeField]
    int maxcount;
    bool started;



    public Button continueButton;

    public GameObject enemyTop;
    public GameObject enemyMiddle;
    public GameObject enemyDown;
    bool firstRound;
    

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
    }

    // Update is called once per frame
    void Update()
    {


        /* if (!enemyMiddle && firstRound == true) 
         {
             Instantiate(enemyMiddle, spawnPointMiddle.position, transform.rotation);
             Debug.LogError("instantiating");
         }*/

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
                Instantiate(enemyDown, spawnPointDown.position, transform.rotation);
                eCount++;
            }


            if (Random.Range(1, 3) == 3)
            {
                Instantiate(enemyDown, spawnPointDown.position, transform.rotation);
                eCount++;
            }
        }





    }

    void TaskOnClick()
    {
        Invoke("Spawner", 5.0f);
        Invoke("FirstRound", 8.0f);
       /* Invoke("FirstRound", 7.0f);*/
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


}
