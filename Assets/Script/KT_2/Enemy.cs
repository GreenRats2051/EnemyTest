using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Animator animator;

    protected virtual void Start()
    {
        
    }

    public abstract void Attack();

    public virtual void Idle()
    {
        animator.SetTrigger("Idle");
    }
}
