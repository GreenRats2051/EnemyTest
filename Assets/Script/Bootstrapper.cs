public class Bootstrapper : MonoBehaviour
{
    private void Awake()
    {
        // Зависимость от EnemyManager и InputListener через AddComponent.
        EnemyManager enemyManager = gameObject.AddComponent<EnemyManager>(); // Зависимость от EnemyManager.
        InputListener inputListener = gameObject.AddComponent<InputListener>(); // Зависимость от InputListener.

        // Инициализация врагов с передачей трансформа игрока.
        enemyManager.InitializeEnemies(inputListener.transform);
    }
}