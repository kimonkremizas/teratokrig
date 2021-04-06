using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour, IAgent, IHittable
{
    [field:SerializeField]
    public int Health { get; set; } = 10;

    private bool dead = false;

    [field: SerializeField]
    public UnityEvent OnGetHit { get; set; }

    [field: SerializeField]
    public UnityEvent OnDeath { get; set; }

    public void GetHit(int damage, GameObject damageDealer)
    {
        if (dead == false)
        {
            Health--;
            OnGetHit?.Invoke();
            if (Health <= 0)
            {
                OnDeath?.Invoke();
                dead = true;
            }
            Debug.Log("Player hit");
        }
    }

}
