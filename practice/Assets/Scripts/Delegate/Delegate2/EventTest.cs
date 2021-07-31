using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {
//            Player.OnPlayerEvent();
            Debug.Log("No event use");
        }
    }
}
