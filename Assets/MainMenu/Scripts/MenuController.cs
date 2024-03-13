using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] string GameScene = "GameScene";
    [SerializeField] string MainMenu = "MainMenuScene";

    public void StartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(GameScene);
    }
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
