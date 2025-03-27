public class Bootstrapper : MonoBehaviour
{
    private void Awake()
    {
        // ����������� �� EnemyManager � InputListener ����� AddComponent.
        EnemyManager enemyManager = gameObject.AddComponent<EnemyManager>(); // ����������� �� EnemyManager.
        InputListener inputListener = gameObject.AddComponent<InputListener>(); // ����������� �� InputListener.

        // ������������� ������ � ��������� ���������� ������.
        enemyManager.InitializeEnemies(inputListener.transform);
    }
}