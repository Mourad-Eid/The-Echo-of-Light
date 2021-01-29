using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    
    [SerializeField] Canvas endGameCanvas;

    private void Start()
    {
        PauseGame();
        endGameCanvas.enabled = false;
        endGameCanvas.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        endGameCanvas.enabled = true;
        endGameCanvas.gameObject.SetActive(true);

    }
    public void DisableCanvas()
    {
        ResumeGame();
        endGameCanvas.enabled = false;
        endGameCanvas.gameObject.SetActive(false);

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
