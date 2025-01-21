using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Enemy[] enemies;
    private int currentEnemyIndex = 0;

    private void Start()
    {
        if (enemies.Length > 0)
        {
            ChangeEnemy();
        }
    }

    public void ChangeEnemy()
    {
        if (enemies.Length == 0) return;

        enemies[currentEnemyIndex].gameObject.SetActive(false);

        currentEnemyIndex = (currentEnemyIndex + 1) % enemies.Length;

        enemies[currentEnemyIndex].gameObject.SetActive(true);
    }

    public void InitializeEnemies(Transform playerTransform)
    {
        foreach (var enemy in enemies)
        {
            if (enemy is EnemyThree enemyThree)
            {
                enemyThree.Initialize(playerTransform);
            }
        }
    }


    public Enemy GetCurrentEnemy()
    {
        return enemies[currentEnemyIndex];
    }
}