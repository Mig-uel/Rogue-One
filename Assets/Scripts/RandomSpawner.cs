using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
  public Transform[] spawnPoints;
  public GameObject[] enemyPrefabs;
  void Start()
  {
    InvokeRepeating("Spawn", 5.0f, 2.0f);
  }
  void Spawn()
  {
    int randEnemy = Random.Range(0, enemyPrefabs.Length);
    int randSpawnPoint = Random.Range(0, spawnPoints.Length);

    Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
  }
}
