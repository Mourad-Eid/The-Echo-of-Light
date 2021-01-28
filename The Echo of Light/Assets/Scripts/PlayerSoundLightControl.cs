using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

public class PlayerSoundLightControl : MonoBehaviour
{
    [SerializeField] SensesLevel[] levels;
    [Header("Light")]
    [SerializeField] Light2D lightSource;
    [Header("Sound")]
    float currentSoundVolume;
    [Header("Detection")]
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] Slider slider;



    public void UpdateLight()
    {
        //update Light
        int sliderValue = (int)slider.value-1;
        lightSource.pointLightInnerRadius = levels[sliderValue].InnerRadius;
        lightSource.pointLightOuterRadius = levels[sliderValue].OuterRadius;
    }

    public void UpdateSound()
    {
        int sliderValue = (int)slider.value - 1;
        EventManager.current.ChangeSound(levels[sliderValue].SoundVolume);
    }

}
