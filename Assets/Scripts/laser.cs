using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public GameObject laserVisibility;
    public GameObject laserVisibility2;

    // Start is called before the first frame update
    void Start()
    {
        laserVisibility.SetActive(false);
        laserVisibility2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
