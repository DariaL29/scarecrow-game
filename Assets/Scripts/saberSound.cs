using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saberSound : MonoBehaviour
{

    private AudioSource saber;
    // Start is called before the first frame update
    void Start()
    {
        saber = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && laserRecharge.currentCharge > 0)
        {
            saber.Play();


        }
       /* else if (!Input.GetKey(KeyCode.Space))
        {
            saber.Stop();*/
        }
    }

