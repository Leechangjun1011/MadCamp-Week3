using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBeam : MonoBehaviour
{

    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid.AddForce(Vector3.forward * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
