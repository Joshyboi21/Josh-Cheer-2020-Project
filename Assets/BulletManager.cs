using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{

    public float shootDistance;
    [SerializeField] GameObject bullet;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBullet", 0f, 2f); // spawn the bullet every 2s
    }

    void spawnBullet()
    {
        // make a bullet
        GameObject thisBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        // set max distance
        thisBullet.GetComponent<ShootBullet>().maxDistance = shootDistance;
    }
}
