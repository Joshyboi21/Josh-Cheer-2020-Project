using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject cameraOne;
    public GameObject cameraTwo;
    public float CamTimer;
   
    // Start is called before the first frame update
    void Start()
    {
        cameraOne.SetActive(true);
        cameraTwo.SetActive(false);
        Invoke("ChangeCamera", CamTimer);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void ChangeCamera()
    {
        cameraOne.SetActive(false);
        cameraTwo.SetActive(true);

    }
}

