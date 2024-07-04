using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver() {
        gameOverScreen.SetActive(true);
    }

    public void GameStart() {
        gameStartScreen.SetActive(false);
    }
}
