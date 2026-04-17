using TMPro;
using UnityEngine;

namespace _Project.Scripts
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverMenu;
        public TMP_Text scoreText;

        private void Start()
        {
           // scoreText = GetComponent<TMP_Text>();
        }

        public void DisplayGameOverMenu()
        {
            _gameOverMenu.SetActive(true);
        }

        public void DisplayScore(int score)
        {
            Debug.Log("Score: " + score);
            scoreText.text = $"Score : {score}";
        }
        
    }
}