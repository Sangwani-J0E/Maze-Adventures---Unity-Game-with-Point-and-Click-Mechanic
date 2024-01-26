using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    void Start(){
        FindObjectOfType<AudioManager>().Play("Theme");
    }
    public void playGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("Back");
        Application.Quit();
        Debug.Log("application quit");
    }

    public void Level1(){
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(1);
    }
    public void Levels()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(38);
    }
    public void menuu()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene("menu");
    }
}
