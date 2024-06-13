using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using TMPro;

public class endScript : MonoBehaviour
{   
    [SerializeField]
    //public GameObject ScoreText;
    public static int score;
    public static TextMeshProUGUI scoretext; // The TextMeshPro object to display

    // Update is called once per frame
    public static void updateScore()
    {
        //ScoreText.text = ("SCORE: " + score);
    }
}