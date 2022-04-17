using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    //public Animator transition;
    //public float transitionTime = 1f;
    public void LoadScene(string sceneName)
    {
        //StartCoroutine(LoadWantedScene(sceneName));
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);


    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        //StartCoroutine(LoadWantedScene("Main Menu"));
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");

    }

    public void CloseGame()
    {
        Application.Quit();
    }

    //IEnumerator LoadWantedScene(string sceneName)
    //{
    //    transition.SetTrigger("Start");
    //    yield return new WaitForSeconds(transitionTime);
    //    UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    //}
}
