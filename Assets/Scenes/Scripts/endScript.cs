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
    public Button restartButton;

    void Start(){
        endscore = PlayerPrefs.GetInt("Score");
        scoretext.text = "SCORE: " + endscore;
        //restartButton.onClick.AddListener(RestartGame);
    }
    // void Update(){
    //     restartButton.onClick.AddListener(RestartGame);
    // }
     public void setEndScore(int score){
         endscore = score;
    }
    // void RestartGame()
    // {
    //     SceneManager.LoadScene("selectSong");
    // }
}