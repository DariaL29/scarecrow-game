using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setActive : MonoBehaviour
{
    public Button continueButton2;
    public GameObject countdownObject;
    public int countdownTime;
    public Text countdown;
    public bool boss;
    // Start is called before the first frame update
    void Start()
    {
        continueButton2.onClick.AddListener(TaskOnClickSetActive);
        boss = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown.text == "GO!")
        {
            Invoke("activeOff", 2.0f);
        }
    }
    void TaskOnClickSetActive()
    {

        countdownObject.SetActive(true);

        if (countdownObject.activeInHierarchy == true)
        {
            Debug.LogError("COUNTDOWN ACTIVE");
        }
        StartCoroutine(CountdownWait());
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
        boss = true;
    }

    void activeOff()
    {
        countdownObject.SetActive(false);
    }



}


