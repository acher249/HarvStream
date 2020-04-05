using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject HeliCam;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(HeliCam.activeInHierarchy == false)
            {
                HeliCam.SetActive(true);
            } 
            else if(HeliCam.activeInHierarchy == true)
            {
                HeliCam.SetActive(false);
            }

            if(MainCam.activeInHierarchy == false)
            {
                MainCam.SetActive(true);
            } 
            else if(MainCam.activeInHierarchy == true)
            {
                MainCam.SetActive(false);
            }
        }
    }
}
