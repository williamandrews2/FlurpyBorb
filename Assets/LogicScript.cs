using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    // Remember this must be dragged and dropped in as a reference in Unity.
    public GameObject gameOverScreen;

    // Context Menu can be used while the game is running (3 dots next to Logic Script).
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        // Had to import (using) UnityEngine.UI
        playerScore+=scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        // Had to import (using) SceneMangement
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    //Function to trigger when the bird crashes into a pipe.
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
