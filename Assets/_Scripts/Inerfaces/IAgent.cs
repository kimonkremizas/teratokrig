using UnityEngine;
using UnityEngine.Events;

public interface IAgent
{
    int Health { get; }
    UnityEvent OnGetHit { get; set; }
    UnityEvent OnDeath { get; set; }
}