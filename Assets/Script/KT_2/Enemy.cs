using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected Animator animator;

    protected Animator Animator => animator;

    public abstract void Attack();

    public virtual void Idle()
    {
        Animator.SetTrigger("Idle");
    }
}