using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawningEnemieslvl1 : MonoBehaviour
{
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
         firstRound = false;
        continueButton.onClick.AddListener(TaskOnClick);
       
    }

    // Update is called once per frame
    void Update()
    {
      
           
            if (!enemyMiddle && firstRound == true) 
            {
                Instantiate(enemyMiddle, spawnPointMiddle.position, transform.rotation);
                Debug.LogError("instantiating");
            }
        
    }

    void TaskOnClick()
    {
        Invoke("Spawner", 5.0f);
        Invoke("FirstRound", 7.0f);
    }



    void Spawner()
        {
        Instantiate(enemyDown, spawnPointDown.position, transform.rotation);
        Instantiate(enemyMiddle, spawnPointMiddle.position, transform.rotation);
        Instantiate(enemyTop, spawnPointTop.position, transform.rotation);
       
        }

   void FirstRound()
    {
        firstRound = true;
    }


}
