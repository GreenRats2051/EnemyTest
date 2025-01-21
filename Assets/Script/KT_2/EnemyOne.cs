public class EnemyOne : Enemy
{
    protected override void Start()
    {
        base.Start();
        Attack();
    }

    public override void Attack()
    {
        animator.SetTrigger("Attack_01");
    }
}
