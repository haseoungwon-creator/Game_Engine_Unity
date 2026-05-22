using UnityEngine;

public class AnimatorManger : MonoBehaviour
{
    public Animator animator;
    public AnimatorStateInfo animatorStateInfo;

    public void Idle()
    {

        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
            animator.SetBool("Idle", true);
        }
        else if (animatorStateInfo.IsName("Run"))
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Run", false);
        }
    }

    public void Run()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
            animator.SetBool("Run", true);
        }
        else if(animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
            animator.SetBool("Run",true);
        }  
    }

    public void Attack()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (animatorStateInfo.IsName("Run"))
        {
            animator.SetBool("Attack", true);
            animator.SetBool("Run", false);
        }
        else if (animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
            animator.SetBool("Attack", true);
        }
    }
    public void Die()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (!(animator.IsInTransition(0)) != animatorStateInfo.IsName("Die"))
        {
            animator.SetTrigger("Die");
        }
    }
}
