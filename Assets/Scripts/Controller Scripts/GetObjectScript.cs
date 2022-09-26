using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObjectScript : MonoBehaviour
{
    private const string selectedMode = "Selected Mode";
    private const string selectedLevel = "Selected Level";

    [Header("Modes")]
    public GameObject playerWalk;
    public GameObject playerKickboard;
    public GameObject playerBike;
    public GameObject playerCar;

    [Header("Walk Levels")]
    public GameObject[] walkLevels;

    [Header("Kickboard Levels")]
    public GameObject[] kickboardLevels;

    [Header("Bike Levels")]
    public GameObject[] bikeLevels;

    [Header("Car Levels")]
    public GameObject[] carLevels;

    public bool loadPlayer;

    void Start()
    {
        loadPlayer = false;
        GetLevel();
    }

    private void Update() {
        if(loadPlayer == true){
            GetMode();
        }
    }

    public void GetMode(){
        int getMode = PlayerPrefs.GetInt(selectedMode);
        switch (getMode)
        {
            case 1:
                playerWalk.SetActive(true);
                break;
            case 2:
                playerKickboard.SetActive(true);
                break;
            case 3:
                playerBike.SetActive(true);
                break;
            case 4:
                playerCar.SetActive(true);
                break;
            default:
                break;
        }
    }

    public void GetLevel(){
        int getMode = PlayerPrefs.GetInt(selectedMode);
        int getLevel = PlayerPrefs.GetInt(selectedLevel);

        if(getMode == 1){
            switch (getLevel)
            {
                case 1:
                    walkLevels[0].SetActive(true);
                    break;
                case 2:
                    walkLevels[1].SetActive(true);
                    break;
                case 3:
                    walkLevels[2].SetActive(true);
                    break;
                case 4:
                    walkLevels[3].SetActive(true);
                    break;
                case 5:
                    walkLevels[4].SetActive(true);
                    break;
                default:
                    walkLevels[0].SetActive(true);
                    break;
            }
        }

        if(getMode == 2){
            switch (getLevel)
            {
                case 1:
                    kickboardLevels[0].SetActive(true);
                    break;
                case 2:
                    kickboardLevels[1].SetActive(true);
                    break;
                case 3:
                    kickboardLevels[2].SetActive(true);
                    break;
                case 4:
                    kickboardLevels[3].SetActive(true);
                    break;
                case 5:
                    kickboardLevels[4].SetActive(true);
                    break;
                default:
                    kickboardLevels[0].SetActive(true);
                    break;
            }
        }

        if(getMode == 3){
            switch (getLevel)
            {
                case 1:
                    bikeLevels[0].SetActive(true);
                    break;
                case 2:
                    bikeLevels[1].SetActive(true);
                    break;
                case 3:
                    bikeLevels[2].SetActive(true);
                    break;
                case 4:
                    bikeLevels[3].SetActive(true);
                    break;
                case 5:
                    bikeLevels[4].SetActive(true);
                    break;
                default:
                    bikeLevels[0].SetActive(true);
                    break;
            }
        }

        if(getMode == 4){
            switch (getLevel)
            {
                case 1:
                    carLevels[0].SetActive(true);
                    break;
                case 2:
                    carLevels[1].SetActive(true);
                    break;
                case 3:
                    carLevels[2].SetActive(true);
                    break;
                case 4:
                    carLevels[3].SetActive(true);
                    break;
                case 5:
                    carLevels[4].SetActive(true);
                    break;
                default:
                    carLevels[0].SetActive(true);
                    break;
            }
        }
    }
}
