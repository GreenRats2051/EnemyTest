using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOne : IStratergy
{
    private int damage;

    public AttackOne(int damage)
    {
        this.damage = damage;
    }

    public void Attack()
    {
        Debug.Log($"You attacked and caused {damage} damage. This is the first attack!");
    }
}
