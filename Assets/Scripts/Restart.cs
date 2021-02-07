using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{

        public Button restart;


        void Start()
        {
            restart.onClick.AddListener(TaskOnClick);
        }

        // Update is called once per frame
        void Update()
        {

        }
        void TaskOnClick()
        {
        SceneManager.LoadScene("StartMenu");

        }




    }

