using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WonUI : MonoBehaviour
{

    public GameObject bossHealth;
    public GameObject UIWon;
    //public GameObject SequenceController;
    
        
        
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<InstantiateBoss>().bossAlreadyThere == true)
        {
            Invoke("LaunchUILost", 6f);
        }
    }


    void LaunchUILost()
    {
        if ( GetComponent<InstantiateBoss>().bossAlreadyThere == true && GameObject.FindGameObjectsWithTag("boss").Length == 0 && bossHealth.GetComponent<bossHealth>().currentHealthEnemy <= 0)
        {
            UIWon.SetActive(true);
            Debug.LogError("Script is accessed");
        }
    }
}
