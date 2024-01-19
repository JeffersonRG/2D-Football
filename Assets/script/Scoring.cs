using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    public TextMeshProUGUI Pampers;
    private int Score;

    // Update is called once per frame
    void Update()
    {
        Pampers.text = ("Pampers | ") + Score.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score++;
        }
    }
}
