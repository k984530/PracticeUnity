using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    Vector3 pos = new Vector3(0f,250f,0f);


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(pos);
        }
    }
}
