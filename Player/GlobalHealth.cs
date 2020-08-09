﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour {

    public static int PlayerHealth = 10;
    public int InternalHealth;
    public GameObject HealthDisplay;

    //updates every frame

    void Update()
    {
        InternalHealth = PlayerHealth;
        HealthDisplay.GetComponent<Text> ().text = "Health: " + PlayerHealth;
        if (PlayerHealth == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
