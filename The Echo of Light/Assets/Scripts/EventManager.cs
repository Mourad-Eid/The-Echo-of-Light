using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static EventManager current;
    private void Awake()
    {
        current = this;
    }

    //chhange sound level event
    public event Action<float> onChangeSound;
    public void ChangeSound(float newSoundVolume)
    {
        onChangeSound?.Invoke(newSoundVolume);
    }
}
