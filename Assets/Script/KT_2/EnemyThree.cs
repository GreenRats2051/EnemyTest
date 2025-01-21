using UnityEngine;

public class EnemyThree : Enemy
{
    private Transform player;

    public void Initialize(Transform playerTransform)
    {
        player = playerTransform;
    }

    private void Update()
    {
        if (player != null && Vector2.Distance(transform.position, player.position) < 5f)
        {
            Attack();
        }
        else
        {
            Idle();
        }
    }

    public override void Attack()
    {
        Animator.SetTrigger("Attack");
    }
}