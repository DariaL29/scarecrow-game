using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rulesUI : MonoBehaviour
{
    public GameObject rules;
    public GameObject secondPart;
   
    // Start is called before the first frame update
    void Start()
    {

        rules.SetActive(true);
        secondPart.SetActive(false);

    }

    // Update is called once per frame


   
}
