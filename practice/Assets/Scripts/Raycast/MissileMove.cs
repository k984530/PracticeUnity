using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    void Update()
    {
        if (transform.position.z > 30) {
            this.gameObject.SetActive(false);
        }       
    }
}
