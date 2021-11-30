using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1UI : MonoBehaviour
{
    public void RestartButton()
    {
        GameManage.shootCount = 0;
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene("Level1");
    }
}
