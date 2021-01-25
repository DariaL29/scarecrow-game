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
   
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        if (GameObject.Find("SequenceController").GetComponent<setActive>().boss == true && bossAlreadyThere == false)
        {
            Invoke("SpawnBoss", 2.0f);
            bossAlreadyThere = true;
        }


        if ( bossAlreadyThere == true)
        {
            //Invoke("movingBossRandomly", 5.0f);
            StartCoroutine("CountdownWait");
        }




    }
     /*void movingBossRandomly()
    {
      
            if (Random.Range(1,30) == 5)
            {

                boss.transform.position = spawnPointDown.position;
            
            }

            if (Random.Range(1, 30) == 10)
            {

                boss.transform.position = spawnPointTop.position;
                
            }

            if (Random.Range(1, 30) == 20)
            {
                boss.transform.position = spawnPointMiddle.position;
               
            }

        
     } */

    void SpawnBoss()
    {
        Instantiate(boss, spawnPointDown.position, transform.rotation);
    }


    IEnumerator CountdownWait()
    {
        yield return new WaitForSeconds(5);
        boss.transform.position = spawnPointDown.position;
        Debug.LogError("TRANSFORM");
    }


}
