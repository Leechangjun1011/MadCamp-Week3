using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Beam : MonoBehaviour
{
    
    public GameObject missileObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if (Input.touchCount > 0 && touch.phase == TouchPhase.Began)
        {
            UnityEngine.Object newMissile;

            newMissile = Instantiate(missileObject, transform.position, transform.rotation);

            Destroy(newMissile, (float)3.0);
            
        }
    }
}
