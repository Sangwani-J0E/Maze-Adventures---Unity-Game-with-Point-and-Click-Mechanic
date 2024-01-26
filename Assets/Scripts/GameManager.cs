using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float Delay = 1f;
    bool GameEnded = false;

    public GameObject RestartUi;
    void OnTriggerEnter()
    { 
        Debug.Log("Game Has Ended");
    }
    public void EndGame()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            RestartUi.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void home(){
        SceneManager.LoadScene("menu");
        Debug.Log("back");
    }
}