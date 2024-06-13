using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using TMPro;

public class EndScript : MonoBehaviour
{   
    public int endscore = 0;
    public TextMeshProUGUI scoretext;

    void Start(){
        endscore = PlayerPrefs.GetInt("Score");
        scoretext.text = "SCORE: " + endscore;
    }
    public void setEndScore(int score){
        endscore = score;
    }
}