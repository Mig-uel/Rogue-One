using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  [SerializeField] GameObject menus;

  public void StartGame(int sceneID)
  {
    SceneManager.LoadScene(sceneID);
  }

  public void Pause()
  {
    menus.SetActive(true);

    AudioListener.pause = true;
    Time.timeScale = 0;
  }
  public void Resume()
  {
    menus.SetActive(false);

    AudioListener.pause = false;
    Time.timeScale = 1f;
  }
  public void Quit(int sceneID)
  {
    SceneManager.LoadScene(sceneID);
  }
}
