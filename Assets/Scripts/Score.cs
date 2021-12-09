using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

  public Text scoreText;
  private int score;

  public void addScore(int num)
  {
    score += num;
    scoreText.text = "Score: " + score;
    if (score >= 100) SceneManager.LoadScene(7);
  }
  public void subScore(int num)
  {
    if (score > 0)
    {
      score -= num;
      scoreText.text = "Score: " + score;
    }
    if (score == 100) SceneManager.LoadScene(7);
  }
}
