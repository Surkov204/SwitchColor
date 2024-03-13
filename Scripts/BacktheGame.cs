using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BacktheGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Switch_color");
    }
}
