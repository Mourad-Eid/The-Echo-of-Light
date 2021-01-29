using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //[SerializeField] AudioSource mainTrack;
    public PlayerActionControls playerActionControls;
    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
        //mainTrack.Play();
    }
    private void OnEnable()
    {
        playerActionControls.Enable();
    }
    private void OnDisable()
    {
        playerActionControls.Disable();
    }


}
