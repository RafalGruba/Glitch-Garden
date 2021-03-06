﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 100;
    [SerializeField] int damage = 1;
    TMP_Text livesText;

    void Start()
    {
        livesText = GetComponent<TMP_Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }
    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
