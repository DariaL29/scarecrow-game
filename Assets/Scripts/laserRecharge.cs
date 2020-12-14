using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laserRecharge : MonoBehaviour
{
    public int maxCharge = 100;
    public static int currentCharge;
    public Slider slider;


    public GameObject laserVisibility;
    public GameObject laserVisibility2;

    bool OutOfCharge;

    // Start is called before the first frame update
    void Start()
    {
        currentCharge = maxCharge;
        OutOfCharge = false;
       slider.maxValue = maxCharge;
    }

    // Update is called once per frame
    void Update()
    {






        // recharging laser 
        if (currentCharge < maxCharge && !Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(Recharge());
        }
       

        //turning the laser on and off on button press
        if (Input.GetKey(KeyCode.Space ) && currentCharge > 0)
        {
            LaserActive();
        }
        else
        {
            laserVisibility.SetActive(false);
            laserVisibility2.SetActive(false);
        }


        slider.value = currentCharge;

        StartCoroutine(DoEverySecond());

   
    }


    void LaserActive()
    {

        laserVisibility.SetActive(true);
        laserVisibility2.SetActive(true);

    }

    IEnumerator DoEverySecond()
    {

        yield return new WaitForSeconds(1f);
        lessCharge();
        StartCoroutine(DoEverySecond());

    }

    void lessCharge()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            currentCharge = currentCharge - 1;
            Debug.Log("less charge");
        }
    }



    IEnumerator Recharge()
    {

        yield return new WaitForSeconds(2f);
        rechargeFunction();
        Debug.Log("coroutine reached");
        StartCoroutine(Recharge());

    }

   
    void rechargeFunction()
    {
        currentCharge = currentCharge + 1;
    }

   




}
