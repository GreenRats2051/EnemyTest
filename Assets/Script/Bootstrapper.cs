using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private void Awake()
    {
        EnemyManager enemyManager = gameObject.AddComponent<EnemyManager>();
        InputListener inputListener = gameObject.AddComponent<InputListener>();

        enemyManager.InitializeEnemies(inputListener.transform);
    }
}
