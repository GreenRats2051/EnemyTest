public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Enemy[] enemies;
    private int currentEnemyIndex = 0;

    private void Start()
    {
        // Зависимость от массива врагов.
        if (enemies.Length > 0)
        {
            ChangeEnemy();
        }
    }

    public void ChangeEnemy()
    {
        if (enemies.Length == 0) return;

        // Отключение текущего врага и переход к следующему.
        enemies[currentEnemyIndex].gameObject.SetActive(false);

        currentEnemyIndex = (currentEnemyIndex + 1) % enemies.Length;

        enemies[currentEnemyIndex].gameObject.SetActive(true);
    }

    public void InitializeEnemies(Transform playerTransform)
    {
        // Инициализация врагов с передачей трансформа игрока.
        foreach (var enemy in enemies)
        {
            if (enemy is EnemyThree enemyThree)
            {
                enemyThree.Initialize(playerTransform); // Зависимость от EnemyThree.
            }
        }
    }

    public Enemy GetCurrentEnemy()
    {
        return enemies[currentEnemyIndex];
    }
}