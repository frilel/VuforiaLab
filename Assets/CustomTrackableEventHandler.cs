using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        AudioSource[] sounds = GetComponentsInChildren<AudioSource>();
        sounds[0].Play();
    }

protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        AudioSource[] sounds = GetComponentsInChildren<AudioSource>();
        sounds[0].Stop();
    }

}