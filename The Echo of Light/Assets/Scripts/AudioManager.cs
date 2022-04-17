using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource level_1;
    [SerializeField] AudioSource level_2;
    [SerializeField] AudioSource level_3;
    [SerializeField] AudioSource level_4;
    [SerializeField] AudioSource level_5;
    [SerializeField] AudioSource level_6;
    [SerializeField] AudioSource level_7;

    void Start()
    {
        EventManager.current.onChangeTrack += ChangeTrack;

        level_1.Play();
        level_2.Play();
        level_3.Play();
        level_3.volume = 0;
        level_4.Play();
        level_4.volume = 0;
        level_5.Play();
        level_5.volume = 0;
        level_6.Play();
        level_6.volume = 0;
        level_7.Play();
        level_7.volume = 0;


    }

    private void OnDestroy()
    {
        EventManager.current.onChangeTrack -= ChangeTrack;
    }

    void ChangeTrack(int level)
    {
        switch(level)
        {
            case 1:
                level_1.volume = 1;
                level_2.volume = 1;
                level_3.volume = 0;
                level_4.volume = 0;
                level_5.volume = 0;
                level_6.volume = 0;
                level_7.volume = 0;
                break;
            case 2:
                level_1.volume = 1;
                level_2.volume = 1;
                level_3.volume = 1;
                level_4.volume = 0;
                level_5.volume = 0;
                level_6.volume = 0;
                level_7.volume = 0;
                break;
            case 3:
                level_1.volume = 1;
                level_2.volume = 1;
                level_3.volume = 1;
                level_4.volume = 1;
                level_5.volume = 1;
                level_6.volume = 0;
                level_7.volume = 0;
                break;
            case 4:
                level_1.volume = 1;
                level_2.volume = 1;
                level_3.volume = 1;
                level_4.volume = 1;
                level_5.volume = 1;
                level_6.volume = 1;
                level_7.volume = 0;
                break;
            case 5:
                level_1.volume = 1;
                level_2.volume = 1;
                level_3.volume = 1;
                level_4.volume = 1;
                level_5.volume = 1;
                level_6.volume = 1;
                level_7.volume = 1;
                break;

        }
    }

}
