using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableZoom : MonoBehaviour
{
    
    public GameObject zoom_00;
    public GameObject zoomEffect_00;
    public GameObject zoom_01;
    public GameObject zoomEffect_01;
    public GameObject zoom_02;
    public GameObject zoomEffect_02;
    public GameObject zoom_03;
    public GameObject zoomEffect_03;
    public GameObject zoom_04;
    public GameObject zoomEffect_04;
    public GameObject zoom_05;
    public GameObject zoomEffect_05;
    public GameObject zoom_06;
    public GameObject zoomEffect_06;

    public GameObject zoom_10;
    public GameObject zoomEffect_10;
    public GameObject zoom_11;
    public GameObject zoomEffect_11;
    public GameObject zoom_12;
    public GameObject zoomEffect_12;
    public GameObject zoom_13;
    public GameObject zoomEffect_13;
    public GameObject zoom_14;
    public GameObject zoomEffect_14;
    public GameObject zoom_15;
    public GameObject zoomEffect_15;
    public GameObject zoom_16;
    public GameObject zoomEffect_16;

    public GameObject zoom_20;
    public GameObject zoomEffect_20;
    public GameObject zoom_21;
    public GameObject zoomEffect_21;
    public GameObject zoom_22;
    public GameObject zoomEffect_22;
    public GameObject zoom_23;
    public GameObject zoomEffect_23;
    public GameObject zoom_24;
    public GameObject zoomEffect_24;
    public GameObject zoom_25;
    public GameObject zoomEffect_25;
    public GameObject zoom_26;
    public GameObject zoomEffect_26;

    public GameObject zoom_30;
    public GameObject zoomEffect_30;
    public GameObject zoom_31;
    public GameObject zoomEffect_31;
    public GameObject zoom_32;
    public GameObject zoomEffect_32;
    public GameObject zoom_33;
    public GameObject zoomEffect_33;
    public GameObject zoom_34;
    public GameObject zoomEffect_34;
    public GameObject zoom_35;
    public GameObject zoomEffect_35;
    public GameObject zoom_36;
    public GameObject zoomEffect_36;

    private AudioSource musicPlayer;
    public AudioClip effectSound;

    int open_exist;
    
    ArrayList dist;
    ArrayList zoom_pos;

    float last_touch;

    // Start is called before the first frame update
    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        dist = new ArrayList();
        zoom_pos = new ArrayList();
        open_exist = -1;
        zoom_00.gameObject.SetActive(false);
        zoomEffect_00.gameObject.SetActive(false);
        zoom_01.gameObject.SetActive(false);
        zoomEffect_01.gameObject.SetActive(false);
        zoom_02.gameObject.SetActive(false);
        zoomEffect_02.gameObject.SetActive(false);
        zoom_03.gameObject.SetActive(false);
        zoomEffect_03.gameObject.SetActive(false);
        zoom_04.gameObject.SetActive(false);
        zoomEffect_04.gameObject.SetActive(false);
        zoom_05.gameObject.SetActive(false);
        zoomEffect_05.gameObject.SetActive(false);
        zoom_06.gameObject.SetActive(false);
        zoomEffect_06.gameObject.SetActive(false);

        zoom_10.gameObject.SetActive(false);
        zoomEffect_10.gameObject.SetActive(false);
        zoom_11.gameObject.SetActive(false);
        zoomEffect_11.gameObject.SetActive(false);
        zoom_12.gameObject.SetActive(false);
        zoomEffect_12.gameObject.SetActive(false);
        zoom_13.gameObject.SetActive(false);
        zoomEffect_13.gameObject.SetActive(false);
        zoom_14.gameObject.SetActive(false);
        zoomEffect_14.gameObject.SetActive(false);
        zoom_15.gameObject.SetActive(false);
        zoomEffect_15.gameObject.SetActive(false);
        zoom_16.gameObject.SetActive(false);
        zoomEffect_16.gameObject.SetActive(false);

        zoom_20.gameObject.SetActive(false);
        zoomEffect_20.gameObject.SetActive(false);
        zoom_21.gameObject.SetActive(false);
        zoomEffect_21.gameObject.SetActive(false);
        zoom_22.gameObject.SetActive(false);
        zoomEffect_22.gameObject.SetActive(false);
        zoom_23.gameObject.SetActive(false);
        zoomEffect_23.gameObject.SetActive(false);
        zoom_24.gameObject.SetActive(false);
        zoomEffect_24.gameObject.SetActive(false);
        zoom_25.gameObject.SetActive(false);
        zoomEffect_25.gameObject.SetActive(false);
        zoom_26.gameObject.SetActive(false);
        zoomEffect_26.gameObject.SetActive(false);

        zoom_30.gameObject.SetActive(false);
        zoomEffect_30.gameObject.SetActive(false);
        zoom_31.gameObject.SetActive(false);
        zoomEffect_31.gameObject.SetActive(false);
        zoom_32.gameObject.SetActive(false);
        zoomEffect_32.gameObject.SetActive(false);
        zoom_33.gameObject.SetActive(false);
        zoomEffect_33.gameObject.SetActive(false);
        zoom_34.gameObject.SetActive(false);
        zoomEffect_34.gameObject.SetActive(false);
        zoom_35.gameObject.SetActive(false);
        zoomEffect_35.gameObject.SetActive(false);
        zoom_36.gameObject.SetActive(false);
        zoomEffect_36.gameObject.SetActive(false);


        Vector2 zoom_pos_00 = new Vector2(488, -365);
        zoom_pos.Add(zoom_pos_00);
        Vector2 zoom_pos_01 = new Vector2(741, -365);
        zoom_pos.Add(zoom_pos_01);
        Vector2 zoom_pos_02 = new Vector2(1041, -365);
        zoom_pos.Add(zoom_pos_02);
        Vector2 zoom_pos_03 = new Vector2(1338, -365);
        zoom_pos.Add(zoom_pos_03);
        Vector2 zoom_pos_04 = new Vector2(1589, -365);
        zoom_pos.Add(zoom_pos_04);
        Vector2 zoom_pos_05 = new Vector2(1889, -365);
        zoom_pos.Add(zoom_pos_05);
        Vector2 zoom_pos_06 = new Vector2(2139, -365);
        zoom_pos.Add(zoom_pos_06);

        Vector2 zoom_pos_10 = new Vector2(488, -665);
        zoom_pos.Add(zoom_pos_10);
        Vector2 zoom_pos_11 = new Vector2(741, -665);
        zoom_pos.Add(zoom_pos_11);
        Vector2 zoom_pos_12 = new Vector2(1041, -665);
        zoom_pos.Add(zoom_pos_12);
        Vector2 zoom_pos_13 = new Vector2(1338, -665);
        zoom_pos.Add(zoom_pos_13);
        Vector2 zoom_pos_14 = new Vector2(1589, -665);
        zoom_pos.Add(zoom_pos_14);
        Vector2 zoom_pos_15 = new Vector2(1889, -665);
        zoom_pos.Add(zoom_pos_15);
        Vector2 zoom_pos_16 = new Vector2(2139, -665);
        zoom_pos.Add(zoom_pos_16);

        Vector2 zoom_pos_20 = new Vector2(488, -915);
        zoom_pos.Add(zoom_pos_20);
        Vector2 zoom_pos_21 = new Vector2(741, -915);
        zoom_pos.Add(zoom_pos_21);
        Vector2 zoom_pos_22 = new Vector2(1041, -915);
        zoom_pos.Add(zoom_pos_22);
        Vector2 zoom_pos_23 = new Vector2(1338, -915);
        zoom_pos.Add(zoom_pos_23);
        Vector2 zoom_pos_24 = new Vector2(1589, -915);
        zoom_pos.Add(zoom_pos_24);
        Vector2 zoom_pos_25 = new Vector2(1889, -915);
        zoom_pos.Add(zoom_pos_25);
        Vector2 zoom_pos_26 = new Vector2(2139, -915);
        zoom_pos.Add(zoom_pos_26);

        Vector2 zoom_pos_30 = new Vector2(488, -1190);
        zoom_pos.Add(zoom_pos_30);
        Vector2 zoom_pos_31 = new Vector2(741, -1190);
        zoom_pos.Add(zoom_pos_31);
        Vector2 zoom_pos_32 = new Vector2(1041, -1190);
        zoom_pos.Add(zoom_pos_32);
        Vector2 zoom_pos_33 = new Vector2(1338, -1190);
        zoom_pos.Add(zoom_pos_33);
        Vector2 zoom_pos_34 = new Vector2(1589, -1190);
        zoom_pos.Add(zoom_pos_34);
        Vector2 zoom_pos_35 = new Vector2(1889, -1190);
        zoom_pos.Add(zoom_pos_35);
        Vector2 zoom_pos_36 = new Vector2(2139, -1190);
        zoom_pos.Add(zoom_pos_36);




    }


    void playSound(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.Stop();
        audioPlayer.clip = clip;
        audioPlayer.loop = false;
        audioPlayer.time = 0;
        audioPlayer.Play();
    }


    void show_effect_00()
    {
        bool isActive = zoom_00.activeSelf;
        zoom_00.gameObject.SetActive(!isActive);
    }
    void show_effect_01()
    {
        bool isActive = zoom_01.activeSelf;
        zoom_01.gameObject.SetActive(!isActive);
    }
    void show_effect_02()
    {
        bool isActive = zoom_02.activeSelf;
        zoom_02.gameObject.SetActive(!isActive);
    }
    void show_effect_03()
    {
        bool isActive = zoom_03.activeSelf;
        zoom_03.gameObject.SetActive(!isActive);
    }
    void show_effect_04()
    {
        bool isActive = zoom_04.activeSelf;
        zoom_04.gameObject.SetActive(!isActive);
    }
    void show_effect_05()
    {
        bool isActive = zoom_05.activeSelf;
        zoom_05.gameObject.SetActive(!isActive);
    }
    void show_effect_06()
    {
        bool isActive = zoom_06.activeSelf;
        zoom_06.gameObject.SetActive(!isActive);
    }



    void show_effect_10()
    {
        bool isActive = zoom_10.activeSelf;
        zoom_10.gameObject.SetActive(!isActive);
    }
    void show_effect_11()
    {
        bool isActive = zoom_11.activeSelf;
        zoom_11.gameObject.SetActive(!isActive);
    }
    void show_effect_12()
    {
        bool isActive = zoom_12.activeSelf;
        zoom_12.gameObject.SetActive(!isActive);
    }
    void show_effect_13()
    {
        bool isActive = zoom_13.activeSelf;
        zoom_13.gameObject.SetActive(!isActive);
    }
    void show_effect_14()
    {
        bool isActive = zoom_14.activeSelf;
        zoom_14.gameObject.SetActive(!isActive);
    }
    void show_effect_15()
    {
        bool isActive = zoom_15.activeSelf;
        zoom_15.gameObject.SetActive(!isActive);
    }
    void show_effect_16()
    {
        bool isActive = zoom_16.activeSelf;
        zoom_16.gameObject.SetActive(!isActive);
    }



    void show_effect_20()
    {
        bool isActive = zoom_20.activeSelf;
        zoom_20.gameObject.SetActive(!isActive);
    }
    void show_effect_21()
    {
        bool isActive = zoom_21.activeSelf;
        zoom_21.gameObject.SetActive(!isActive);
    }
    void show_effect_22()
    {
        bool isActive = zoom_22.activeSelf;
        zoom_22.gameObject.SetActive(!isActive);
    }
    void show_effect_23()
    {
        bool isActive = zoom_23.activeSelf;
        zoom_23.gameObject.SetActive(!isActive);
    }
    void show_effect_24()
    {
        bool isActive = zoom_24.activeSelf;
        zoom_24.gameObject.SetActive(!isActive);
    }
    void show_effect_25()
    {
        bool isActive = zoom_25.activeSelf;
        zoom_25.gameObject.SetActive(!isActive);
    }
    void show_effect_26()
    {
        bool isActive = zoom_26.activeSelf;
        zoom_26.gameObject.SetActive(!isActive);
    }


    void show_effect_30()
    {
        bool isActive = zoom_30.activeSelf;
        zoom_30.gameObject.SetActive(!isActive);
    }
    void show_effect_31()
    {
        bool isActive = zoom_31.activeSelf;
        zoom_31.gameObject.SetActive(!isActive);
    }
    void show_effect_32()
    {
        bool isActive = zoom_32.activeSelf;
        zoom_32.gameObject.SetActive(!isActive);
    }
    void show_effect_33()
    {
        bool isActive = zoom_33.activeSelf;
        zoom_33.gameObject.SetActive(!isActive);
    }
    void show_effect_34()
    {
        bool isActive = zoom_34.activeSelf;
        zoom_34.gameObject.SetActive(!isActive);
    }
    void show_effect_35()
    {
        bool isActive = zoom_35.activeSelf;
        zoom_35.gameObject.SetActive(!isActive);
    }
    void show_effect_36()
    {
        bool isActive = zoom_36.activeSelf;
        zoom_36.gameObject.SetActive(!isActive);
    }


    void close_effect(int i)
    {
        
        int col = 7;

        ArrayList effect_list = new ArrayList();
        effect_list.Add(zoomEffect_00);
        effect_list.Add(zoomEffect_01);
        effect_list.Add(zoomEffect_02);
        effect_list.Add(zoomEffect_03);
        effect_list.Add(zoomEffect_04);
        effect_list.Add(zoomEffect_05);
        effect_list.Add(zoomEffect_06);

        effect_list.Add(zoomEffect_10);
        effect_list.Add(zoomEffect_11);
        effect_list.Add(zoomEffect_12);
        effect_list.Add(zoomEffect_13);
        effect_list.Add(zoomEffect_14);
        effect_list.Add(zoomEffect_15);
        effect_list.Add(zoomEffect_16);

        effect_list.Add(zoomEffect_20);
        effect_list.Add(zoomEffect_21);
        effect_list.Add(zoomEffect_22);
        effect_list.Add(zoomEffect_23);
        effect_list.Add(zoomEffect_24);
        effect_list.Add(zoomEffect_25);
        effect_list.Add(zoomEffect_26);

        effect_list.Add(zoomEffect_30);
        effect_list.Add(zoomEffect_31);
        effect_list.Add(zoomEffect_32);
        effect_list.Add(zoomEffect_33);
        effect_list.Add(zoomEffect_34);
        effect_list.Add(zoomEffect_35);
        effect_list.Add(zoomEffect_36);

        int index_x = i % 10;
        int index_y = i / 10;

        int index = index_x + col * index_y;

        GameObject ToClose = (GameObject)effect_list[index];

        ToClose.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        Touch touch = Input.GetTouch(0);

        if (Input.touchCount > 0 && touch.phase == TouchPhase.Began)
        {
            last_touch = Time.time;

        }

        if(touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
        {
            if(Time.time - last_touch < 0.5)
            {

                if (open_exist != -1)
                {

                    if (open_exist < 7)
                    {
                        close_effect(open_exist);
                        Invoke("show_effect_0" + open_exist.ToString(), 0);
                    }
                    else if (open_exist < 14)
                    {
                        open_exist += 3;
                        close_effect(open_exist);
                        Invoke("show_effect_" + open_exist.ToString(), 0);
                    }
                    else if (open_exist < 21)
                    {
                        open_exist += 6;
                        close_effect(open_exist);
                        Invoke("show_effect_" + open_exist.ToString(), 0);
                    }
                    else
                    {
                        open_exist += 9;
                        close_effect(open_exist);
                        Invoke("show_effect_" + open_exist.ToString(), 0);
                    }
                    open_exist = -1;
                    return;
                }

                Vector2 touch_pos = touch.position;
                touch_pos.y -= 1500;
                dist = new ArrayList();
                float min;
                int min_index = 0;
                min = Vector2.Distance(touch_pos, (Vector2)zoom_pos[0]);
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        dist.Add(Vector2.Distance(touch_pos, (Vector2)zoom_pos[7 * j + i]));
                        if (min > (float)dist[7 * j + i])
                        {
                            min_index = 7 * j + i;
                            min = (float)dist[7 * j + i];
                        }
                    }
                }

                playSound(effectSound, musicPlayer);

                

                if (min_index == 0)
                {
                    zoomEffect_00.gameObject.SetActive(true);
                    Invoke("show_effect_00", (float)0.6833);
                    open_exist = 0;
                }

                else if (min_index == 1)
                {
                    zoomEffect_01.gameObject.SetActive(true);
                    Invoke("show_effect_01", (float)0.6833);
                    open_exist = 1;
                }
                else if (min_index == 2)
                {
                    zoomEffect_02.gameObject.SetActive(true);
                    Invoke("show_effect_02", (float)0.6833);
                    open_exist = 2;
                }
                else if (min_index == 3)
                {
                    zoomEffect_03.gameObject.SetActive(true);
                    Invoke("show_effect_03", (float)0.6833);
                    open_exist = 3;
                }
                else if (min_index == 4)
                {
                    zoomEffect_04.gameObject.SetActive(true);
                    Invoke("show_effect_04", (float)0.6833);
                    open_exist = 4;
                }
                else if (min_index == 5)
                {
                    zoomEffect_05.gameObject.SetActive(true);
                    Invoke("show_effect_05", (float)0.6833);
                    open_exist = 5;
                }
                else if (min_index == 6)
                {
                    zoomEffect_06.gameObject.SetActive(true);
                    Invoke("show_effect_06", (float)0.6833);
                    open_exist = 6;
                }



                else if (min_index == 7)
                {
                    zoomEffect_10.gameObject.SetActive(true);
                    Invoke("show_effect_10", (float)0.6833);
                    open_exist = 7;
                }
                else if (min_index == 8)
                {
                    zoomEffect_11.gameObject.SetActive(true);
                    Invoke("show_effect_11", (float)0.6833);
                    open_exist = 8;
                }
                else if (min_index == 9)
                {
                    zoomEffect_12.gameObject.SetActive(true);
                    Invoke("show_effect_12", (float)0.6833);
                    open_exist = 9;
                }
                else if (min_index == 10)
                {
                    zoomEffect_13.gameObject.SetActive(true);
                    Invoke("show_effect_13", (float)0.6833);
                    open_exist = 10;
                }
                else if (min_index == 11)
                {
                    zoomEffect_14.gameObject.SetActive(true);
                    Invoke("show_effect_14", (float)0.6833);
                    open_exist = 11;
                }
                else if (min_index == 12)
                {
                    zoomEffect_15.gameObject.SetActive(true);
                    Invoke("show_effect_15", (float)0.6833);
                    open_exist = 12;
                }
                else if (min_index == 13)
                {
                    zoomEffect_16.gameObject.SetActive(true);
                    Invoke("show_effect_16", (float)0.6833);
                    open_exist = 13;
                }


                else if (min_index == 14)
                {
                    zoomEffect_20.gameObject.SetActive(true);
                    Invoke("show_effect_20", (float)0.6833);
                    open_exist = 14;
                }
                else if (min_index == 15)
                {
                    zoomEffect_21.gameObject.SetActive(true);
                    Invoke("show_effect_21", (float)0.6833);
                    open_exist = 15;
                }
                else if (min_index == 16)
                {
                    zoomEffect_22.gameObject.SetActive(true);
                    Invoke("show_effect_22", (float)0.6833);
                    open_exist = 16;
                }
                else if (min_index == 17)
                {
                    zoomEffect_23.gameObject.SetActive(true);
                    Invoke("show_effect_23", (float)0.6833);
                    open_exist = 17;
                }
                else if (min_index == 18)
                {
                    zoomEffect_24.gameObject.SetActive(true);
                    Invoke("show_effect_24", (float)0.6833);
                    open_exist = 18;
                }
                else if (min_index == 19)
                {
                    zoomEffect_25.gameObject.SetActive(true);
                    Invoke("show_effect_25", (float)0.6833);
                    open_exist = 19;
                }
                else if (min_index == 20)
                {
                    zoomEffect_26.gameObject.SetActive(true);
                    Invoke("show_effect_26", (float)0.6833);
                    open_exist = 20;
                }



                else if (min_index == 21)
                {
                    zoomEffect_30.gameObject.SetActive(true);
                    Invoke("show_effect_30", (float)0.6833);
                    open_exist = 21;
                }
                else if (min_index == 22)
                {
                    zoomEffect_31.gameObject.SetActive(true);
                    Invoke("show_effect_31", (float)0.6833);
                    open_exist = 22;
                }
                else if (min_index == 23)
                {
                    zoomEffect_32.gameObject.SetActive(true);
                    Invoke("show_effect_32", (float)0.6833);
                    open_exist = 23;
                }
                else if (min_index == 24)
                {
                    zoomEffect_33.gameObject.SetActive(true);
                    Invoke("show_effect_33", (float)0.6833);
                    open_exist = 24;
                }
                else if (min_index == 25)
                {
                    zoomEffect_34.gameObject.SetActive(true);
                    Invoke("show_effect_34", (float)0.6833);
                    open_exist = 25;
                }
                else if (min_index == 26)
                {
                    zoomEffect_35.gameObject.SetActive(true);
                    Invoke("show_effect_35", (float)0.6833);
                    open_exist = 26;
                }
                else if (min_index == 27)
                {
                    zoomEffect_36.gameObject.SetActive(true);
                    Invoke("show_effect_36", (float)0.6833);
                    open_exist = 27;
                }
            }

        }
    }
}
