using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    private float startX;
    public float speed;
    public GameObject projectilePrefab;
    public float maxDistance;
   
    // Start is called before the first frame update
    void Start()
    {
        // record x pos of where bullet begins
        startX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // move the bullet
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        // delete bullet after it has travelled max distance
        if (transform.position.x < (startX - maxDistance)) 
        {
            Destroy(gameObject);
        }
    }
}
