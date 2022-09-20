using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public Text scoreText, ticketText;
    public GameObject startGameCanvas, inGameCanvas, missionCanvas, pauseMenuCanvas, finishGameCanvas;
    
    public int score, ticketNum;

    public bool stopCountingScore;
    // Start is called before the first frame update
    void Start()
    {
        stopCountingScore = false;
    }

    void Update(){
        scoreText.text = "" + score;
        ticketText.text = "" + ticketNum;
        
        if(stopCountingScore == true){
            finishGameCanvas.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            OpenPauseMenu();
        }

        if(Input.GetKeyDown(KeyCode.M)){
            OpenMissionCanvas();
        }
    }

    // PAUSE MENU
    public void OpenPauseMenu(){
        inGameCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame(){
        inGameCanvas.SetActive(true);
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame(){
        Time.timeScale = 1f;
        Application.Quit();
    }

    // MISSION MENU
    public void OpenMissionCanvas(){
        inGameCanvas.SetActive(false);
        missionCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseMissionCanvas(){
        inGameCanvas.SetActive(true);
        missionCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

}
