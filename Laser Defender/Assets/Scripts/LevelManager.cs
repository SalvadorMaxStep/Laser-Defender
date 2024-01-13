using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 2f;
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadExit()
    {
        StartCoroutine(WaitAndLoad("EndGame", sceneLoadDelay));
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator WaitAndLoad(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
