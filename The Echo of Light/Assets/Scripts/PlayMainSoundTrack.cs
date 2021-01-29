using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMainSoundTrack : MonoBehaviour
{
    [SerializeField] AudioSource mainSoundTrack;
    void Start()
    {
        mainSoundTrack.Play();
    }

}
