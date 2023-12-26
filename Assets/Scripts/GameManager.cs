using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {

    public FishBehaviour player;
    public FishBehaviour enemy;

    public Pebble pebble;

    public TMP_Text playerScoreText;
    public TMP_Text enemyScoreText;

    private float playerScore;
    private float enemyScore;

    public GameObject gameOverPanel;
    public GameObject pausePanel;
    public TMP_Text winnerText;
    public int gameMode; // 1 = single player, 2 = multiplayer
    

    public void PlayerScores() {
        this.playerScore++;
        this.playerScoreText.text = this.playerScore.ToString();

        this.ResetRound();
    }

    public void EnemyScores() {

        this.enemyScore++;
        this.enemyScoreText.text = this.enemyScore.ToString();

        this.ResetRound();
    }


    public void Update() {
            
        if (this.playerScore >= 10 || this.enemyScore >= 10) {
            this.GameOver();
        }

        // pause handling
        if (Input.GetKeyDown(KeyCode.P)) {
            if (Time.timeScale == 1) {
                Time.timeScale = 0;
                this.pausePanel.gameObject.SetActive(true);      
            } else {
                Time.timeScale = 1;
                this.pausePanel.gameObject.SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.Q)) {
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

    public void GameOver() {

        // pause the game
        Time.timeScale = 0;
    
        this.gameOverPanel.gameObject.SetActive(true);

        if (this.playerScore >= 10) 
            this.winnerText.text = "Player 1 wins!";
        else 
            this.winnerText.text = "Player 2 wins!";
        
        // user can press space to restart the game
        if (Input.GetKeyDown(KeyCode.Space)) {
            this.gameOverPanel.gameObject.SetActive(false);
            
            // restart the game
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene(gameMode);
        }

        // if user presses "q" return to the main menu
        if (Input.GetKeyDown(KeyCode.Q)) {
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

    public void ResetScore() {

        playerScore = 0;
        enemyScore = 0;
        playerScoreText.text = playerScore.ToString();
        enemyScoreText.text = enemyScore.ToString();
    } 
    
    public void ResetRound() {
        
        this.pebble.ResetPosition();
        this.player.ResetPlayerPosition();
        this.enemy.ResetPlayerPosition();
        this.pebble.AddInitialForce();
    }

}
