using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace _Project.Scripts
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverMenu;
        [SerializeField] private GameObject welcomeMenu;
        public TMP_Text scoreText;
        public TMP_Text highscoreText;
        public List<int> highScoresList = new List<int>();
        public int highScore => highScoresList[0];
        
        [HideInInspector] public BirdController birdcontroller;

        private void Start()
        {
           // scoreText = GetComponent<TMP_Text>();
           highScoresList.Add(1);
            
        if (highScoresList.Count == 0)
        {
            Debug.Log("The list is empty. No maximum value can be found.");
        }
        int maxManual = highScoresList[0];
        foreach (int num in highScoresList)
        {
            if (num > maxManual)
                maxManual = num;
        }
        highscoreText.text = $"Score : {maxManual}";
            //int maxValue = highScoresList.Max();
            //highscoreText.text = $"Highest number (LINQ):{maxValue}";
        }
    
    

        public void DisplayGameOverMenu()
        {
            _gameOverMenu.SetActive(true);
        }

        public void DisplayScore(int score)
        {
            Debug.Log("Score: " + score);
            scoreText.text = $"Score : {score}";
            highScoresList.Add(score);
        }
        public void DisplayHighScore(int highscore)
        {
            Debug.Log("High Score: " + highscore);
            highscoreText.text = $"Score : {highscore}";
        }

        public void ShowStartMenu()
        {
            welcomeMenu.SetActive(true);
            DisplayHighScore(highScore);
        }
    }
}