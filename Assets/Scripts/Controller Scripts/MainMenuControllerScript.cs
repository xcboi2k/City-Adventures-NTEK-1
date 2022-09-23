using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControllerScript : MonoBehaviour
{
    public void EnterGame(){
        SceneManager.LoadScene("SelectModeScene");
    }

    public void OpenRankings(){
        SceneManager.LoadScene("RankingScene");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
