using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMotion : MonoBehaviour
{

    public GameObject Hand_On;
    public GameObject Hand_Off;
    float last_touch;
    bool no_hand;

    // Start is called before the first frame update
    void Start()
    {
        no_hand = true;
        Hand_On.gameObject.SetActive(false);
        Hand_Off.gameObject.SetActive(false);
    }

    void hide_hand()
    {
        Hand_Off.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if (Input.touchCount > 0 && touch.phase == TouchPhase.Began)
        {
            last_touch = Time.time;
        }

        if (touch.phase == TouchPhase.Canceled || touch.phase == TouchPhase.Ended)
        {
            if(Time.time - last_touch >= 0.5)
            {
                if (no_hand)
                {
                    Hand_On.gameObject.SetActive(true);
                    no_hand = false;
                }

                else
                {
                    no_hand = true;
                    Hand_On.gameObject.SetActive(false);
                    Hand_Off.gameObject.SetActive(true);
                    Invoke("hide_hand", 0.8f);
                }

            }
        }

    }
}
