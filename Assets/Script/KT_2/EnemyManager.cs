using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy[] enemies;
    private int currentEnemyIndex = 0;
    private Enemy currentEnemy;

    private void Start()
    {
        if (enemies.Length != 0)
        {
            enemies[0].gameObject.SetActive(false);
        }
    }

    public void ChangeEnemy()
    {
        currentEnemyIndex = (currentEnemyIndex + 1) % enemies.Length;
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].gameObject.SetActive(currentEnemyIndex == i);
        }
    }
}

