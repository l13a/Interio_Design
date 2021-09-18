using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int currentSceneIndex;

    public void QuitGame(){
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("WelcomePage");
    }

    public void ContinueDesign(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }
}
