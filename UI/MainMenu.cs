using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //public List<GameObject> FxAudios;
    public GameObject creditsPanel;

    private void Start()
    {
        creditsPanel.SetActive(false);
    }

    public void GoToScene(int nextScene)
    {
        SceneManager.LoadScene(nextScene);

    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
    }
    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}