using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform punchPoint;
    public float punchRange = 0.5f;
    public LayerMask enemyLayers;

    public float punchRate = 2f;
    private float nextPunchTime = 0f;
    public int punchDamage = 2;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextPunchTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextPunchTime = Time.time + 1f / punchRate;
            }
        }
       
    }
    void Attack()
    {
        //Play Atack
        animator.SetTrigger("Attack");
        //Detect
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(punchPoint.position, punchRange, enemyLayers);
        //Damage
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().GetHit(punchDamage, gameObject);          
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (punchPoint == null)
            return;
        Gizmos.DrawWireSphere(punchPoint.position, punchRange);
    }
}

