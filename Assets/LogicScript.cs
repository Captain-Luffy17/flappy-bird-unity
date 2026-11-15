using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI ScoreText;
    public GameObject GameOverPanel;

    [ContextMenu("Increase Score")]
    public void ScoreUp(int points)
    {
        score += points;
        ScoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }
    
}
