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
  }
  public void subScore()
  {
    score -= 5;
    scoreText.text = "Score: " + score;
  }
}
