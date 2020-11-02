using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public GameObject winScreen;
    private Text timeText;
    private float timePlayed;


    private void Start()
    {
        winScreen.SetActive(false); // hide win screen
        timeText = winScreen.transform.Find(
            "time").GetComponent<Text>(); // get text element
        timePlayed = 0; // timer (starting at 0 when game starts)
    }

    private void Update()
    {
        timePlayed += Time.deltaTime; // keep increaseing the timer
    }

    // Player Win!!
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winScreen.SetActive(true); // show win screen
        string time = "It only took you " + System.Math.Round(timePlayed, 2) + "s";
        timeText.text = time; // set text to display time
    }

}
