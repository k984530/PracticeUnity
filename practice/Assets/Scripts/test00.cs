﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test00 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody;
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }
}
