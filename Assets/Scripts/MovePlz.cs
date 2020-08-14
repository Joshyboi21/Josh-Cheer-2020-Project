using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlz : MonoBehaviour
{

    public float speed = 5f;
    public float stopPosition = 6f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0);

        if (transform.position.y >= stopPosition)
        {
          speed = 0f;
                                          }
       
    }
}
