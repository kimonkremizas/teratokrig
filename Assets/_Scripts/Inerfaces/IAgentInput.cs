using UnityEngine;
using UnityEngine.Events;

public interface IAgentInput
{
    UnityEvent<Vector2> OnMovementKeyPressed { get; set; }
    UnityEvent<Vector2> OnPointerPositionChanged { get; set; }
    UnityEvent OnFireButtonPressed { get; set; }
    UnityEvent OnFireButtonReleased { get; set; }
}