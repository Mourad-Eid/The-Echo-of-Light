using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SensesLevel 
{
    [Header("Light")]
    [SerializeField] float innerRdius;
    [SerializeField] float outerRadius;

    [Header("Sound")]
    [SerializeField] float soundVolume;

    public float InnerRadius => innerRdius;
    public float OuterRadius => outerRadius;
    public float SoundVolume => soundVolume;
}
