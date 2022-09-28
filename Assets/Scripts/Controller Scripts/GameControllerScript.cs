using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    private const string selectedLevel = "Selected Level";

    public GameObject defaultCamera;

    [Header("Canvas Objects")]
    public GameObject startGameCanvas; 
    public GameObject inGameCanvas; 
    public GameObject missionCanvas;
    public GameObject pauseMenuCanvas;
    public GameObject finishGameCanvas;
    public GameObject deathCanvas;

    [Header("In Game Objects")]
    public Text coinText;
    public Text ticketText;

    [Header("Finish Game Objects")]
    public Text finalLevelText;
    public Text finalScoreText; 
    public Text finalCoinText; 
    public Text finalTicketText;
    public Text levelText;

    [HideInInspector]
    public int coin, ticketNum;
    [HideInInspector]
    public bool stopCountingScore, isGameFinished, isPlayerAccident;

    private float fs;
    public int finalScore, getLevel;

    // Start is called before the first frame update
    void Start()
    {
        stopCountingScore = false;
        isGameFinished = false;
        defaultCamera.SetActive(true);
        startGameCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update(){
        coinText.text = "" + coin;
        ticketText.text = "" + ticketNum;

        if(isPlayerAccident == true){
            OpenDeathCanvas();
            Time.timeScale = 0f;
        }
        
        if(stopCountingScore == true){
            isGameFinished = true;
            finishGameCanvas.SetActive(true);
            Time.timeScale = 0f;

            int getLevel = PlayerPrefs. GetInt(selectedLevel);
            switch (getLevel)
            {
                case 1:
                    finalLevelText.text = "Level 1";
                    break;
                case 2:
                    finalLevelText.text = "Level 2";
                    break;
                case 3:
                    finalLevelText.text = "Level 3";
                    break;
                case 4:
                    finalLevelText.text = "Level 4";
                    break;
                case 5:
                    finalLevelText.text = "Level 5";
                    break;
                default:
                    break;
            }
            
            fs = coin * 2f - ticketNum * 2f;
            finalScore = (int)fs;
            finalCoinText.text = "" + coin;
            finalTicketText.text = "" + ticketNum;
            finalScoreText.text = "" + finalScore;
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            OpenPauseMenu();
        }

        if(Input.GetKeyDown(KeyCode.M)){
            OpenMissionCanvas();
        }
        // fsText = finalScoreText.text;
        // finalScore = int.Parse(fsText);
    }

    public void StartGame(){
        startGameCanvas.SetActive(false);
        inGameCanvas.SetActive(true);
        defaultCamera.SetActive(false);
        GameObject.Find("Game Controller").GetComponent<GetObjectScript>().loadPlayer = true;
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
        SceneManager.LoadScene("MainMenuScene");
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
    }

    public void NextLevel(){
        coin = 0;
        ticketNum = 0;
        finishGameCanvas.SetActive(false);

        int getLevel = PlayerPrefs.GetInt(selectedLevel);
        int newLevel = getLevel+1;
        PlayerPrefs.SetInt(selectedLevel, newLevel);

        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }

    //ACCIDENT
    public void OpenDeathCanvas()
    {
        inGameCanvas.SetActive(false);
        deathCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

}
