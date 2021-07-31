using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class Player : MonoBehaviour
{

    int health = 50;
    GameObject[] enemyObj;
    public float speed = 3f;
    public int Health {
        get { return health; }
        set {
            health = Mathf.Clamp(value, 0, 100);
        }
    }

    void Awake() {
        enemyObj = GameObject.FindGameObjectsWithTag("ENEMY");
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Health = Health - 5;
            Debug.Log(Health);
        }

        PlayerMove();

        //        if (Health <= 0) GameManager.instance.NotifyEvent(GameManager.EventType.Die);
        if (Health <= 0)
            foreach (GameObject obj in enemyObj)
                obj.SendMessage("OnPlayerDie", SendMessageOptions.DontRequireReceiver);
    }

    void PlayerMove() {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * -speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
     }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CHECKPOINT")) {
            //            GameManager.instance.NotifyEvent(GameManager.EventType.Touch);
            foreach (GameObject cmp in enemyObj)
                cmp.SendMessage("OnPlayerDetection", SendMessageOptions.DontRequireReceiver);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("CHECKPOINT")) {
            //    GameManager.instance.NotifyEvent(GameManager.EventType.ExitTouch);
            foreach (GameObject cmp in enemyObj)
                cmp.SendMessage("OnPlayerExitDetection", SendMessageOptions.DontRequireReceiver);
        }
    }
}
