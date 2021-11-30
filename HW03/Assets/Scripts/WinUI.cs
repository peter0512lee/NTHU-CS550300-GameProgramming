using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinUI : MonoBehaviour
{
    public void NextLevelButton()
    {
        GameManage.shootCount = 0;
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene("Level2");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
