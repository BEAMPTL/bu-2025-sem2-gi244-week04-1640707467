using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Wave currentWave;
    public Transform[] spawnPoints;

    private int enemySpawned = 0;
    private int nextSpawnTime = 0;
    void Update()
    {
        var t = Time.time;
        if (t > nextSpawnTime && enemySpawned < currentWave.enemycount)
        {
            Spawn();
            enemySpawned += 1;
            nextSpawnTime = Time.time + currentWave.spawnInterval;
        }
    }
    void Spawn()
    {
        int enemyIndex = Random.Range(0, currentWave.enemyPrefabs.Length);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(
            currentWave.enemyPrefabs][enemyIndex],
        spawnPoint[spawnPointIndex].position,
        currentWave.enemyPrefabs][enemyIndex].tranform.rotation);
    }
}
