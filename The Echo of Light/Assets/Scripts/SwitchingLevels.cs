using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingLevels : MonoBehaviour
{
    [SerializeField] SceneManager sceneManager;
    [SerializeField] string levelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sceneManager.LoadScene(levelName);
    }

}
