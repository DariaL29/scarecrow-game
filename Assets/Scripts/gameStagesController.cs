using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameStagesController : MonoBehaviour
{
    public Button continueButton;
    public Button continueButton2;
    
    public GameObject rules;
    public GameObject secondPart;


    public int countdownTime;
    public Text countdown;
    public GameObject countdownObject;
    bool SetInactive;


    // Start is called before the first frame update
    void Start()
    {
        continueButton.onClick.AddListener(TaskOnClick);
        continueButton2.onClick.AddListener(TaskOnClick2);
        SetInactive = false;
    }

    // Update is called once per frame
    void Update()
    {

      if (rules.activeInHierarchy == true || secondPart.activeInHierarchy == true)
        {
            PauseGame();
        }
      
       if (countdown.text == "GO!")
        {
            Invoke("activeOff", 2.0f);
        }

        //when all enemies are killed start a boss stage of a game

        if (GameObject.FindGameObjectsWithTag("enemy").Length == 0 && GameObject.Find("Spawner").GetComponent<spawningEnemieslvl1>().eCount == GameObject.Find("Spawner").GetComponent<spawningEnemieslvl1>().maxcount && SetInactive == false)
        {
         
            secondPart.SetActive(true);

        }

        if ( secondPart.activeInHierarchy == false)
        {
            ResumeGame();
        }



    }


    void TaskOnClick()
    {
        countdownObject.SetActive(true);
        rules.SetActive(false);
        ResumeGame();
        StartCoroutine(CountdownWait());
        
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }


    IEnumerator CountdownWait()
    {
        while (countdownTime > 0)
        {
            Debug.Log("Coroutine!");
            countdown.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f); 
            countdownTime--;
        }
        countdown.text = "GO!";

    }

    void activeOff()
    {
        countdownObject.SetActive(false);
    }

    void TaskOnClick2()
    {
        SetInactive = true;
        secondPart.SetActive(false);
        Debug.LogError("SET ACTIVE FALSE");
        countdownObject.SetActive(true);
       
     
       
        
    }


}
