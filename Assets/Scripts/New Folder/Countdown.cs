using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour

{
   // public int countdownTime;
   // public static Text countdown;
    public GameObject countdownObject;


    // Start is called before the first frame update
    void Start()
    {

        countdownObject.SetActive(false);
        //StartCoroutine(CountdownWait());
    }

    // Update is called once per frame
    void Update()
    {

    }



   /* IEnumerator CountdownWait()
    {
        while (countdownTime > 0)
        {
            countdown.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdown.text = "GO!";
    }*/


}
