using UnityEngine;

namespace _Project.Scripts
{
    public class PlayersPrefs : MonoBehaviour
    {
        void Start()
        {
            // --- Saving data ---
            PlayerPrefs.SetInt("HighScore", 1500);       // Save an integer
            PlayerPrefs.SetFloat("Volume", 0.8f);        // Save a float
            PlayerPrefs.SetString("PlayerName", "Alex"); // Save a string

            // Force save to disk (optional, usually done automatically on quit)
            //PlayerPrefs.Save();

            // --- Loading data ---
            int highScore = PlayerPrefs.GetInt("HighScore", 0); // Default value if not found
            float volume = PlayerPrefs.GetFloat("Volume", 1.0f);
            string playerName = PlayerPrefs.GetString("PlayerName", "Guest");

            Debug.Log($"HighScore: {highScore}, Player: {playerName}");
           // Debug.Log($"HighScore: {highScore}, Volume: {volume}, Player: {playerName}");

            // --- Deleting data ---
            // PlayerPrefs.DeleteKey("HighScore"); // Delete a specific key
            // PlayerPrefs.DeleteAll(); // Delete ALL saved keys (use with caution)
        }
        //public void SaveSettings(float volume, string username)
        public void SaveSettings(string key,string username)
        {
           // PlayerPrefs.SetFloat("Volume", volume);
           // PlayerPrefs.SetString("Username", username);
            PlayerPrefs.SetString("Username", username);
            PlayerPrefs.Save();
        }

        public void LoadSettings()
        {
           // float volume = PlayerPrefs.GetFloat("Volume", 1.0f);
            string username = PlayerPrefs.GetString("Username", "Guest");
            //avec Volume
            // Debug.Log($"Loaded settings: Volume={volume}, Username={username}");
            Debug.Log($"Loaded settings: Username={username}");
        }

    }
}
