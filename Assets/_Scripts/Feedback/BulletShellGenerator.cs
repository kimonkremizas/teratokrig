using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BulletShellGenerator : ObjectPool
{
    [SerializeField] private float flyDuration = 0.3f;
    [SerializeField] private float flyStrength = 1;

    public void SpawnBulletShell()
    {
        var shell = SpawnObject();
        MoveShellInRandomDirection(shell);
    }

    private void MoveShellInRandomDirection(GameObject shell)
    {
        shell.transform.DOComplete();
        var randomDIrection = Random.insideUnitCircle;
        randomDIrection = randomDIrection.y > 0 ? new Vector2(randomDIrection.x, -randomDIrection.y) : randomDIrection;
        
        shell.transform.DOMove(((Vector2) transform.position + randomDIrection) * flyStrength, flyDuration)
            .OnComplete(() => shell.GetComponent<AudioSource>().Play());
        shell.transform.DORotate(new Vector3(0, 0, Random.Range(0f, 360f)), flyDuration);
    }
}
