using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    [Header("Canvas Objects")]
    public GameObject startGameCanvas; 
    public GameObject inGameCanvas; 
    public GameObject missionCanvas;
    public GameObject pauseMenuCanvas;
    public GameObject finishGameCanvas;

    [Header("In Game Objects")]
    public Text coinText;
    public Text ticketText;

    [Header("Finish Game Objects")]
    public Text finalScoreText; 
    public Text finalCoinText; 
    public Text finalTicketText;
    public Text levelText;

    [HideInInspector]
    public int coin, ticketNum;
    [HideInInspector]
    public bool stopCountingScore, isGameFinished;

    // Start is called before the first frame update
    void Start()
    {
        stopCountingScore = false;
        isGameFinished = false;

        startGameCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update(){
        coinText.text = "" + coin;
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

    // START VIEW
    public void LoadStartView(){
        // fetch level no. and name
        // fetch level description
        // fetch level character
    }

    public void StartGame(){
        inGameCanvas.SetActive(true);
        startGameCanvas.SetActive(false);
        Time.timeScale = 1f;
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

    // FINISH VIEW
    public void OpenFinishView(){
        inGameCanvas.SetActive(false);
        finishGameCanvas.SetActive(true);
        Time.timeScale = 0f;

        //fetch level no.
        finalCoinText.text = "" + coin;
        finalTicketText.text = "" + ticketNum;
        finalScoreText.text = "" + (coin * 2f - ticketNum * 2f);
    }

    public void NextLevel(){
        coin = 0;
        ticketNum = 0;
        finishGameCanvas.SetActive(false);

        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }

}
