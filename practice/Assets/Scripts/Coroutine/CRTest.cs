using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRTest : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("TestCoroutine"); 
    }

    IEnumerator TestCoroutine() {
        Debug.Log("TestCoroutine() Start");
        yield return new WaitForSeconds(3.0f);
        Debug.Log("3 seconds lapsed");
    }

}
