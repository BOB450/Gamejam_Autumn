﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movearrow : MonoBehaviour
{
    
    public float speed = 1.0f;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
