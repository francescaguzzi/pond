using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public FishBehaviour player;
    public FishBehaviour enemy;

    public Pebble pebble;

    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text enemyScoreText;

    private float playerScore;
    private float enemyScore;
    

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

    
    /*public void ResetScore() {

        playerScore = 0;
        enemyScore = 0;
        playerScoreText.text = playerScore.ToString();
        enemyScoreText.text = enemyScore.ToString();
    } */

    // resetto la posizione della palla e dei giocatori
    public void ResetRound() {
        
        this.pebble.ResetPosition();
        this.player.ResetPlayerPosition();
        this.enemy.ResetPlayerPosition();
        this.pebble.AddInitialForce();
    }

}
