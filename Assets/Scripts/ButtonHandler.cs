﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{

    public void quitGame() {
        // ends game
        Application.Quit();
    }

    public void restart() {
        // restarts game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
