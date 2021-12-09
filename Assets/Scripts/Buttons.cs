using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
  public void StartButton()
  {
    SceneManager.LoadScene(1);
  }
  public void Instructions()
  {
    SceneManager.LoadScene(4);
  }
  public void Settings()
  {
    SceneManager.LoadScene(5);
  }
  public void HighScores()
  {
    SceneManager.LoadScene(6);
  }
  public void Home()
  {
    SceneManager.LoadScene(0);
  }
}
