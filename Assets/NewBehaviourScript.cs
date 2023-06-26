﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.1f, 8.2f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        // transform.Rotate(Vector2.up * 100f * Time.deltaTime); 

    }
}
