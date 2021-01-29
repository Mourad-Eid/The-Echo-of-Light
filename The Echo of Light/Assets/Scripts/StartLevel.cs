using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] Canvas slidebarUI;
    [SerializeField] Canvas pauseMenu;
    void Start()
    {
        PauseGame();
        slidebarUI.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(false);
    }

    public void DisableCanvas()
    {
        ResumeGame();
        slidebarUI.gameObject.SetActive(false);

    }
    public void DisablePauseCanvas()
    {
        ResumeGame();
        pauseMenu.gameObject.SetActive(false);

    }
    public void EnablePauseCanvas()
    {
        PauseGame();
        pauseMenu.gameObject.SetActive(true);

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
