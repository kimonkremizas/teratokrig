using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentPunchAudioPlayer : AudioPlayer
{

    [SerializeField]
    protected AudioClip punchClip;

    public void PlayPunchSound()
    {
        PlayClipWithVariablePitch(punchClip);
    }
}
