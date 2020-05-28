﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public string Success;
    public static int score;

    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        text.text = "Enemies left: " + (20 - score);
        if (score >= 5)
        {
            SceneManager.LoadScene(Success);
        }
    }
}
