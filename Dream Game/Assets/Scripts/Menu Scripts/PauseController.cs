using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public bool isPaused;
    [SerializeField] private GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused) { Time.timeScale = 0; }
        else { Time.timeScale = 1; }

        pauseMenu.SetActive(isPaused);
    }

    public void Unpause()
    {
        isPaused = false;
    }

    public void SaveGame()
    {
        string currentLevel = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("SavedLevel", currentLevel);
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene("Menu");
    }
}
