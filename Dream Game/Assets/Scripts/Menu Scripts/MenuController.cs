using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Levels to Load")]
    public string _newGameLevel;
    private string levelToLoad;
    [SerializeField] private GameObject noGameDialogue;

    public void LoadNewGame()
    {
        SceneManager.LoadScene(_newGameLevel);
    }

    public void LoadSavedGame()
    {
        if (PlayerPrefs.HasKey("SavedLevel"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noGameDialogue.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
