﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // We need this line for uGUI to work.

public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
    }
}
