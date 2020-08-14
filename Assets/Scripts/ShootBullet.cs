﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;
    public float lowerBound;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed); 
     
        if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
            
        }
    }
}
