using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverMenu;

    public void DisplayGameOverMenu()
    {
        Debug.Log("Game Over Menu");
        _gameOverMenu.SetActive(true);
    }
}