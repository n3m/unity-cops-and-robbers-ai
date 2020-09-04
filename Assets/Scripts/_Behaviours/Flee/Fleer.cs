﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Fleer : MonoBehaviour
{
    public Transform target;

    float speed = 4f;
    Vector3 direction;
    Vector3 position;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("target").transform;
        }
        position = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (target != null)
        {
            position = transform.position;
            direction = ((position - target.position) * Time.deltaTime).normalized * speed;
            rb.velocity = direction - rb.velocity;
        }
        else
        {
            direction = Vector3.zero;
        }


    }
}
