using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject SelectCharacter;
    public GameObject mainMenu;


    public void OnSelectCharacter()
    {
        SelectCharacter.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene("LandOfTheDead");
    }

    public void OnQuitButton()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}