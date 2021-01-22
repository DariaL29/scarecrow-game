using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameStagesController : MonoBehaviour
{
    public Button continueButton;
    public GameObject rules;
    public GameObject seconPart;


    public int countdownTime;
    public Text countdown;
    public GameObject countdownObject;



    // Start is called before the first frame update
    void Start()
    {
        
        continueButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

      if (rules.activeInHierarchy == true)
        {
            PauseGame();
        }
      
       if (countdown.text == "GO!")
        {
            Invoke("activeOff", 2.0f);
        }

        //when all enemies are killed start a boss stage of a game

        if (GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            PauseGame();


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

   


}
