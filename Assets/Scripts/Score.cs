using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Bird player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Bird>();
    }

    public void AddScore(int scoreToAdd) {
        if (player.playerIsAlive) 
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
}
