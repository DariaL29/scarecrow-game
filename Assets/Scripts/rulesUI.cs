﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    public GameObject rules;
    public GameObject secondPart;
    public GameObject UILost;
    public GameObject UIwon;
   
    // Start is called before the first frame update
    void Start()
    {

        rules.SetActive(true);
        secondPart.SetActive(false);
        UILost.SetActive(false);
        UIwon.SetActive(false);
    }

    // Update is called once per frame


   
}
