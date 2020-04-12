using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public GameObject complectedLevelUI;

    public void EndGame()
    {
        if(!GameHasEnded)
        {
            GameHasEnded = true;
            Restart();
        }
    }
          
    public void CompletedLevel()
    {
        complectedLevelUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
