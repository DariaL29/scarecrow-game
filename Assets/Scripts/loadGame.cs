using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    public Button play;
    public static bool sceneLoaded;

    // Start is called before the first frame update
    void Start()
    {

        play.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {



       
    }




    void TaskOnClick()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        sceneLoaded = true;
    }
}
