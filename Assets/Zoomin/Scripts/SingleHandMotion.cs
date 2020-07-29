using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleHandMotion : MonoBehaviour
{
    public GameObject singleHandMotion;
    public GameObject hitEffect;
    public GameObject flashEffect;
    float last_touch;

    private AudioSource musicPlayer;
    public AudioClip effectSound;


    Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        singleHandMotion.gameObject.SetActive(false);
        //hitEffect.gameObject.SetActive(false);
    }

    void playSound(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.Stop();
        audioPlayer.clip = clip;
        audioPlayer.loop = false;
        audioPlayer.time = 0;
        audioPlayer.Play();
    }


    void hiteffecton()
    {
        //Vector3 pos = Camera.main.ScreenToViewportPoint(touch.position);
        //GameObject hiteffect = Instantiate(hitEffect, pos, Quaternion.identity);

        float x = 0;
        float y = -20;
        float z = 222;

        //GameObject hiteffect = Instantiate(hitEffect, new Vector3(x, y, z), Quaternion.identity);
        GameObject hiteffect_1 = Instantiate(hitEffect, new Vector3((touch.position.x - 1300)/10, (touch.position.y - 700)/10 - 35, z), Quaternion.identity);
        GameObject hiteffect_2 = Instantiate(hitEffect, new Vector3((touch.position.x - 1300) / 10, (touch.position.y - 700) / 10 - 35, z), Quaternion.identity);
        GameObject hiteffect_3 = Instantiate(hitEffect, new Vector3((touch.position.x - 1300) / 10, (touch.position.y - 700) / 10 - 35, z), Quaternion.identity);
        GameObject flasheffect = Instantiate(flashEffect, new Vector3((touch.position.x - 1300) / 10, (touch.position.y - 700) / 10 - 35, z), Quaternion.identity);
        //GameObject hiteffect_2 = Instantiate(hitEffect, new Vector3(40, -20, 222), Quaternion.identity);
        //Destroy(hiteffect, 2.0f);
        Destroy(hiteffect_1, 2.0f);
        Destroy(hiteffect_2, 2.0f);
        Destroy(hiteffect_3, 2.0f);
        Destroy(flasheffect, 2.0f);
        //Destroy(hiteffect_2, 2.0f);
        //hitEffect.gameObject.SetActive(true);
    }

    void hiteffectoff()
    {

        hitEffect.gameObject.SetActive(false);
    }

    void handsdown()
    {
        singleHandMotion.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        touch = Input.GetTouch(0);
        if (Input.touchCount > 0 && touch.phase == TouchPhase.Began)
        {
            last_touch = Time.time;
        }

        if (touch.phase == TouchPhase.Canceled || touch.phase == TouchPhase.Ended)
        {
            if (Time.time - last_touch >= 0.5)
            {
                playSound(effectSound, musicPlayer);
                singleHandMotion.gameObject.SetActive(true);
                Invoke("hiteffecton", 0.8f);
                //Invoke("hiteffectoff", 3);
                Invoke("handsdown", 1.5f);
            }
        }
    }
}
