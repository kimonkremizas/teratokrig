using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeAttack : EnemyAttack
{
    public Animator animator;

    public override void Attack(int damage)
    {
        if (waitBeforeNextAttack == false)
        {
            var hittable = GetTarget().GetComponent<IHittable>();
            hittable?.GetHit(damage, gameObject);
            animator.SetTrigger("Attack");
            StartCoroutine(WaitBeforeAttackCoroutine());
        }
    }
}
