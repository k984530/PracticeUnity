using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joke : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpaceShipMove();
    }
    void SpaceShipMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Z))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.X))
            transform.Translate(Vector3.back * speed * Time.deltaTime);

// rotate
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.down * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            transform.position = new Vector3(0, 0, 0);
    }
}
