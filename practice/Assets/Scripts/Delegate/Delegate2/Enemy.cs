using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
/*    void Start() {
        GameManager.instance.AddListener(GameManager.EventType.Touch, this.OnPlayerDetection);
        GameManager.instance.AddListener(GameManager.EventType.Die, this.OnPlayerDie);
        GameManager.instance.AddListener(GameManager.EventType.ExitTouch,this.OnPlayerExitDetection);
        Debug.Log("성공");
    }
*/
    void OnPlayerDetection() {
        Debug.Log("Red Alert");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    void OnPlayerDie()
    {
        Debug.Log("Player Dead");
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
    void OnPlayerExitDetection()
    {
        Debug.Log("Red Alert");
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

}
