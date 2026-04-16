using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverMenu;
    public TMP_Text scoreText;

    public void DisplayGameOverMenu()
    {
        _gameOverMenu.SetActive(true);
    }

    public void DisplayScore(int score)
    {
        Debug.Log("Score: " + score);
        scoreText.text = "Score : " + score;
    }
}