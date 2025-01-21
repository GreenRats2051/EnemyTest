using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackContext
{
    private IStratergy _attackStrategy;

    public void SetStrategy(IStratergy strategy)
    {
        _attackStrategy = strategy;
    }

    public void PerformAttack()
    {
        _attackStrategy?.Attack();
    }
}
