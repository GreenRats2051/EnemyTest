using UnityEngine;

public class EnemyThree : Enemy
{
    private Transform player;

    private void Start()
    {
        player = FindObjectOfType<InputListener>().transform;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < 5f) 
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
        animator.SetTrigger("Attack");
    }
}
