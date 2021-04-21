using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Collider2D doorCollider;

    public void MoveCollider()
    {
        doorCollider.transform.position -= new Vector3(0, 0.15f,0);
    }
}
