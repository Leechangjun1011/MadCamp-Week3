using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    float m_fOldTouchDis = 0f; // 터치 이전 거리 저장
    float m_fFieldOfView = 60f; // 카메라의 FieldOfView의 기본값을 60으로 정함.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckTouch();
    }

    void CheckTouch()
    {
        int nTouch = Input.touchCount;
        float m_fTouchDis = 0f;
        float fDis = 0f;

        // 터치가 2개이고, 그 중 하나라도 이동하면 카메라의 fieldOfView를 조정합니다.
        if(Input.touchCount == 2 && (Input.touches[0].phase == TouchPhase.Moved || Input.touches[1].phase == TouchPhase.Moved))
        {
            m_fTouchDis = (Input.touches[0].position - Input.touches[1].position).sqrMagnitude;

            fDis = (m_fTouchDis - m_fOldTouchDis) * 0.01f;

            //이전 2개의 터치의 거리와 지금 거리 차이를 fieldOfView에서 차감합니다.
            m_fFieldOfView -= fDis;

            //최대 100, 최소 20
            m_fFieldOfView = Mathf.Clamp(m_fFieldOfView, 20.0f, 100.0f);

            //확대 / 축소가 갑자기 되지 않도록 보정
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, m_fFieldOfView, Time.deltaTime * 5);

            m_fOldTouchDis = m_fTouchDis;
        }






    }


}
