using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public interface IKnockBack
{
    void KnockBack(Vector2 direction, float power, float duration);
}
