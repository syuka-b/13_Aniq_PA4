﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballrotation : MonoBehaviour
{
    private float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
