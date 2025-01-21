using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTwo : IStratergy
{
    private int damage;

    public AttackTwo(int damage)
    {
        this.damage = damage;
    }

    public void Attack()
    {
        Debug.Log($"You attacked and caused {damage} damage. This is the second attack!");
    }
}
