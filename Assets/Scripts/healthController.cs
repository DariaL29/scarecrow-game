 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthController : MonoBehaviour
{
    public Slider healthSlider;

    public float maxHealth;

    public static float currentHealth;

    public float health = 10;

    public GameObject heart;
    public GameObject UILost;

    

    // Start is called before the first frame update





    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = currentHealth;
        launchUi();
     
    }

    void launchUi()
    {
        if (currentHealth == 0)
        {
            UILost.SetActive(true);
            Time.timeScale = 0;
        }



    

    }




}
