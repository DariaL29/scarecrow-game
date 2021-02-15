using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowSound : MonoBehaviour
{
    private AudioSource audio;
    public GameObject boss;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.activeInHierarchy== true ||  enemy1.activeInHierarchy == true || enemy2.activeInHierarchy == true || enemy3.activeInHierarchy == true)
        {
            audio.Play();
        }

        if (boss.activeInHierarchy == false && enemy1.activeInHierarchy == false && enemy2.activeInHierarchy == false && enemy3.activeInHierarchy == false)
        {
            audio.Stop();
        }
    }
}
