using UnityEngine;

public class EnemyTwo : Enemy
{

    private void Update()
    {
        Attack();
    }

    public override void Attack()
    {
        animator.SetTrigger("Attack_02");
    }
}
