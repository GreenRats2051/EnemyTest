public class EnemyOne : Enemy
{
    void Start()
    {
        Attack();
    }

    public override void Attack()
    {
        animator.SetTrigger("Attack_01");
    }
}
