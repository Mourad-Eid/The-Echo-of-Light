using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] Canvas slidebarUI;
    void Start()
    {
        PauseGame();
        slidebarUI.gameObject.SetActive(true);
    }

    public void DisableCanvas()
    {
        ResumeGame();
        slidebarUI.gameObject.SetActive(false);

    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
