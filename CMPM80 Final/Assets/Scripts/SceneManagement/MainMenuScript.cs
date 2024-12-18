using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class MainMenuScript : MonoBehaviour
{

    private GameController gameController;


    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("PlayerTag").GetComponent<GameController>();
        if(gameController == null)
        {
            Debug.LogError("GameController not found");
        }   
    }   

    public void PlayGame()
    {   
        SceneManager.LoadSceneAsync("CheckpointTest");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadCredits()
    {
        SceneManager.LoadSceneAsync("CreditsMenu");
    }

    public void LoadControls()
    {
        SceneManager.LoadSceneAsync("TutorialMenu");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void Continue()
    {
        Debug.Log("Continue");
        gameController.TogglePause();
    }

}
