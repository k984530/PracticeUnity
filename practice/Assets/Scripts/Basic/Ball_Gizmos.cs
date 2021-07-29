using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Gizmos : MonoBehaviour
{

    public void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position,0.5f);
    }
}
