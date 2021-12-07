using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public static bool ShowingInstructions = false;
  public GameObject pauseMenuUI;
  public GameObject instructionsUI;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (GameIsPaused)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
  }
  public void Resume()
  {
    pauseMenuUI.SetActive(false);
    instructionsUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;
  }
  void Pause()
  {
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
  }
  public void LoadMenu()
  {
    Time.timeScale = 1f;
    SceneManager.LoadScene(0);
  }
  public void QuitGame()
  {
    Application.Quit();
  }
  public void Instructions()
  {
    instructionsUI.SetActive(true);
    pauseMenuUI.SetActive(false);
    ShowingInstructions = true;
  }
}
