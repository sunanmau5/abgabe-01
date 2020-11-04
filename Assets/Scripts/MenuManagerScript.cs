using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public GameObject Menu;
    public Button RestartButton;
    public Button ReturnButton;
    public static bool gameIsPaused;
    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
        RestartButton.onClick.AddListener(Restart);
        ReturnButton.onClick.AddListener(ResumeGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    // If game is currently paused, this methode will resume the game, if not the game will be paused
    void PauseGame()
    {
        if (!gameIsPaused)
        {
            Time.timeScale = 0f;
            Menu.SetActive(true);
            gameIsPaused = true;
        }
        else
        {
            ResumeGame();
        }
    }

    // Resuming the game
    void ResumeGame()
    {
        Time.timeScale = 1;
        Menu.SetActive(false);
        gameIsPaused = false;
    }

    // Restart the game
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ResumeGame();
    }
}
