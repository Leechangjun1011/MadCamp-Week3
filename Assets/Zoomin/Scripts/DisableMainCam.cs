using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMainCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraZoom.disableMainCam.Equals("y"))
        {
            GetComponent<Camera>().enabled = false;
            
        }

        else
        {
            GetComponent<Camera>().enabled = true;
            
        }
    }
}
