using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public static string disableMainCam = "n";

    void Start()
    {
        //GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if (Input.touchCount > 0 && touch.phase == TouchPhase.Began)
        {
            //GetComponent<Camera>().enabled = true;

            if (disableMainCam.Equals("n"))
            {
                disableMainCam = "y";
                
            }

            else
            {
                disableMainCam = "n";
                
            }

        }

        
    }
}
