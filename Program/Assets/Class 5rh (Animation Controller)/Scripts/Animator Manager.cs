using UnityEngine;

public class AnimatorManger : MonoBehaviour
{
    public Animator animator;

    public void Idle()
    {
        animator.SetBool("Run", false);
        animator.SetBool("Attack", false);
    }

    public void Run()
    {
        animator.SetBool("Run", true);
    }

    public void Attack()
    {
        animator.SetBool("Attack", true);
    }
    public void Die()
    {
        animator.SetTrigger("Die");
    }
}
