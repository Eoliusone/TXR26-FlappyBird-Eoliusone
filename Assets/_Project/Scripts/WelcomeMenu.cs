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
    public PlayersPrefs playerPrefs;
    public SpawnPipeManager _spawnPipeManager;

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
        _spawnPipeManager.StartPawnPipe();
    }

    private void OnPlayerNameButtonClick()
    {
        playerPrefs.LoadSettings();
        QuitWelcomeMenu();
    }

    private void QuitWelcomeMenu()
    {
    gameObject.SetActive(false);
    }
}


