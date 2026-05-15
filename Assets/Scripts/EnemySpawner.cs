using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int maxAliveEnemies = 2;
    public float spawnDelay = 2f;

    [Header("Render Setting")]
    public int enemyOrderInLayer = 0;

    private int currentAlive;
    private float spawnTimer;

    void OnEnable()
    {
        Enemy_Health.OnMonsterDefeated += OnEnemyDead;
    }

    void OnDisable()
    {
        Enemy_Health.OnMonsterDefeated -= OnEnemyDead;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (currentAlive < maxAliveEnemies && spawnTimer <= 0)
        {
            SpawnEnemy();
            spawnTimer = spawnDelay;
        }
    }

    void SpawnEnemy()
    {
        GameObject enemy =
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        ApplySortingOrder(enemy);

        currentAlive++;
    }

    void ApplySortingOrder(GameObject enemy)
    {
        SpriteRenderer[] renderers =
            enemy.GetComponentsInChildren<SpriteRenderer>();

        foreach (var r in renderers)
            r.sortingOrder = enemyOrderInLayer;
    }

    void OnEnemyDead(int exp)
    {
        currentAlive--;
    }
}