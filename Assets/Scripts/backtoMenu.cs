using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backtoMenu : MonoBehaviour

{
    public Button menu1;
    public Button menu2;


    // Start is called before the first frame update
    void Start()
    {
       menu1.onClick.AddListener(TaskOnClick);
        menu2.onClick.AddListener(TaskOnClick2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);

    }
    void TaskOnClick2()
    {
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);

    }
}
