using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();
    }

    public void Level1Button()
    {
        GameManage.shootCount = 0;
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene("Level1");
    }

    public void Level2Button()
    {
        GameManage.shootCount = 0;
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene("Level2");
    }
}
