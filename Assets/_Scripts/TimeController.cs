using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public static TimeController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }

    public void ResetTimeScale()
    {
        StopAllCoroutines();
        Time.timeScale = 1;
    }

    public void ModifyTimeScale(float endTImeValue, float timeToWait, Action OnCompleteCallback = null)
    {
        StartCoroutine(TimeScaleCoroutine(endTImeValue, timeToWait, OnCompleteCallback));
    }

    IEnumerator TimeScaleCoroutine(float endTImeValue, float timeToWait, Action OnCompleteCallback = null)
    {
        yield return new WaitForSecondsRealtime(timeToWait);
        Time.timeScale = endTImeValue;
        OnCompleteCallback?.Invoke();
    }

}
