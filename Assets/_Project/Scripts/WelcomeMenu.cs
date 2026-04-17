using System;
using _Project.Scripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WelcomeMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button _playerNameButton;
    [SerializeField] private Button _quitWelcomeButton;
    
    public GameManager gameManager;

    private void Start()
    {
        _playerNameButton.onClick.AddListener(OnPlayerNameButtonClick);
        _quitWelcomeButton.onClick.AddListener(QuitWelcomeButtonn);
    }

    private void QuitWelcomeButtonn()
    {
        Debug.Log("Quit Welcome Button");
        QuitWelcomeMenu();
        gameManager.CreatePlayer();
    }

    private void OnPlayerNameButtonClick()
    {
        PlayerPrefs.SetString("Username", "Guest");
        QuitWelcomeMenu();
    }

    private void QuitWelcomeMenu()
    {
    gameObject.SetActive(false);
    }
}


