using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour
{
    public void ReturnButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}