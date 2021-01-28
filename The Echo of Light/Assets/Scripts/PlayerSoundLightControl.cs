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
    [SerializeField] float soundDetectionRadius;
    float currentSoundVolume;
    [Header("Detection")]
    [SerializeField] LayerMask enemyLayer;

    [SerializeField] Slider slider;


    void Start()
    {
        
    }

    
    void Update()
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, soundDetectionRadius, enemyLayer);
        if (collisions.Length >= 0)
        {
            UpdateSoundVolume(collisions);
        }
    }

    void UpdateSoundVolume(Collider2D[] collisions)
    {
        foreach (Collider2D col in collisions)
        {
            col.GetComponent<AudioSource>().volume = currentSoundVolume;
        }
    
    }

    public void UpdateLightandSound()
    {
        //update Light
        int sliderValue = (int)slider.value-1;
        lightSource.pointLightInnerRadius = levels[sliderValue].InnerRadius;
        lightSource.pointLightOuterRadius = levels[sliderValue].OuterRadius;
        //update sound volume
        currentSoundVolume = levels[sliderValue].SoundVolume;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, soundDetectionRadius);
    }
}
