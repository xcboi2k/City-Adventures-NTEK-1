using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RankingControllerScript : MonoBehaviour
{
    private const string walkLevel1Gold = "Walk Level 1 Gold", walkLevel1Silver = "Walk Level 1 Silver", walkLevel1Bronze = "Walk Level 1 Bronze";
    private const string walkLevel2Gold = "Walk Level 2 Gold", walkLevel2Silver = "Walk Level 2 Silver", walkLevel2Bronze = "Walk Level 2 Bronze";
    private const string walkLevel3Gold = "Walk Level 3 Gold", walkLevel3Silver = "Walk Level 3 Silver", walkLevel3Bronze = "Walk Level 3 Bronze";
    private const string walkLevel4Gold = "Walk Level 4 Gold", walkLevel4Silver = "Walk Level 4 Silver", walkLevel4Bronze = "Walk Level 4 Bronze";
    private const string walkLevel5Gold = "Walk Level 5 Gold", walkLevel5Silver = "Walk Level 5 Silver", walkLevel5Bronze = "Walk Level 5 Bronze";

    private const string kickboardLevel1Gold = "Kickboard Level 1 Gold", kickboardLevel1Silver = "Kickboard Level 1 Silver", kickboardLevel1Bronze = "Kickboard Level 1 Bronze";
    private const string kickboardLevel2Gold = "Kickboard Level 2 Gold", kickboardLevel2Silver = "Kickboard Level 2 Silver", kickboardLevel2Bronze = "Kickboard Level 2 Bronze";
    private const string kickboardLevel3Gold = "Kickboard Level 3 Gold", kickboardLevel3Silver = "Kickboard Level 3 Silver", kickboardLevel3Bronze = "Kickboard Level 3 Bronze";
    private const string kickboardLevel4Gold = "Kickboard Level 4 Gold", kickboardLevel4Silver = "Kickboard Level 4 Silver", kickboardLevel4Bronze = "Kickboard Level 4 Bronze";
    private const string kickboardLevel5Gold = "Kickboard Level 5 Gold", kickboardLevel5Silver = "Kickboard Level 5 Silver", kickboardLevel5Bronze = "Kickboard Level 5 Bronze";

    private const string bikeLevel1Gold = "Bike Level 1 Gold", bikeLevel1Silver = "Bike Level 1 Silver", bikeLevel1Bronze = "Bike Level 1 Bronze";
    private const string bikeLevel2Gold = "Bike Level 2 Gold", bikeLevel2Silver = "Bike Level 2 Silver", bikeLevel2Bronze = "Bike Level 2 Bronze";
    private const string bikeLevel3Gold = "Bike Level 3 Gold", bikeLevel3Silver = "Bike Level 3 Silver", bikeLevel3Bronze = "Bike Level 3 Bronze";
    private const string bikeLevel4Gold = "Bike Level 4 Gold", bikeLevel4Silver = "Bike Level 4 Silver", bikeLevel4Bronze = "Bike Level 4 Bronze";
    private const string bikeLevel5Gold = "Bike Level 5 Gold", bikeLevel5Silver = "Bike Level 5 Silver", bikeLevel5Bronze = "Bike Level 5 Bronze";

    private const string carLevel1Gold = "Car Level 1 Gold", carLevel1Silver = "Car Level 1 Silver", carLevel1Bronze = "Car Level 1 Bronze";
    private const string carLevel2Gold = "Car Level 2 Gold", carLevel2Silver = "Car Level 2 Silver", carLevel2Bronze = "Car Level 2 Bronze";
    private const string carLevel3Gold = "Car Level 3 Gold", carLevel3Silver = "Car Level 3 Silver", carLevel3Bronze = "Car Level 3 Bronze";
    private const string carLevel4Gold = "Car Level 4 Gold", carLevel4Silver = "Car Level 4 Silver", carLevel4Bronze = "Car Level 4 Bronze";
    private const string carLevel5Gold = "Car Level 5 Gold", carLevel5Silver = "Car Level 5 Silver", carLevel5Bronze = "Car Level 5 Bronze";

    public Text goldScoreText, silverScoreText, bronzeScoreText;
    private int mode, levelNum;

    private void Update() {
        switch (mode)
        {
            case 1:
                int getWalk1G = PlayerPrefs.GetInt(walkLevel1Gold);
                int getWalk1S = PlayerPrefs.GetInt(walkLevel1Silver);
                int getWalk1B = PlayerPrefs.GetInt(walkLevel1Bronze);
                int getWalk2G = PlayerPrefs.GetInt(walkLevel2Gold);
                int getWalk2S = PlayerPrefs.GetInt(walkLevel2Silver);
                int getWalk2B = PlayerPrefs.GetInt(walkLevel2Bronze);
                int getWalk3G = PlayerPrefs.GetInt(walkLevel3Gold);
                int getWalk3S = PlayerPrefs.GetInt(walkLevel3Silver);
                int getWalk3B = PlayerPrefs.GetInt(walkLevel3Bronze);
                int getWalk4G = PlayerPrefs.GetInt(walkLevel4Gold);
                int getWalk4S = PlayerPrefs.GetInt(walkLevel4Silver);
                int getWalk4B = PlayerPrefs.GetInt(walkLevel4Bronze);
                int getWalk5G = PlayerPrefs.GetInt(walkLevel5Gold);
                int getWalk5S = PlayerPrefs.GetInt(walkLevel5Silver);
                int getWalk5B = PlayerPrefs.GetInt(walkLevel5Bronze);

                if(levelNum == 1){
                    goldScoreText.text = "" + getWalk1G;
                    silverScoreText.text = "" + getWalk1S;
                    bronzeScoreText.text = "" + getWalk1B;
                }
                if(levelNum == 2){
                    goldScoreText.text = "" + getWalk2G;
                    silverScoreText.text = "" + getWalk2S;
                    bronzeScoreText.text = "" + getWalk2B;
                }
                if(levelNum == 3){
                    goldScoreText.text = "" + getWalk3G;
                    silverScoreText.text = "" + getWalk3S;
                    bronzeScoreText.text = "" + getWalk3B;
                }
                if(levelNum == 4){
                    goldScoreText.text = "" + getWalk4G;
                    silverScoreText.text = "" + getWalk4S;
                    bronzeScoreText.text = "" + getWalk4B;
                }
                if(levelNum == 5){
                    goldScoreText.text = "" + getWalk5G;
                    silverScoreText.text = "" + getWalk5S;
                    bronzeScoreText.text = "" + getWalk5B;
                }
                break;

            case 2:
                int getKickboard1G = PlayerPrefs.GetInt(kickboardLevel1Gold);
                int getKickboard1S = PlayerPrefs.GetInt(kickboardLevel1Silver);
                int getKickboard1B = PlayerPrefs.GetInt(kickboardLevel1Bronze);
                int getKickboard2G = PlayerPrefs.GetInt(kickboardLevel2Gold);
                int getKickboard2S = PlayerPrefs.GetInt(kickboardLevel2Silver);
                int getKickboard2B = PlayerPrefs.GetInt(kickboardLevel2Bronze);
                int getKickboard3G = PlayerPrefs.GetInt(kickboardLevel3Gold);
                int getKickboard3S = PlayerPrefs.GetInt(kickboardLevel3Silver);
                int getKickboard3B = PlayerPrefs.GetInt(kickboardLevel3Bronze);
                int getKickboard4G = PlayerPrefs.GetInt(kickboardLevel4Gold);
                int getKickboard4S = PlayerPrefs.GetInt(kickboardLevel4Silver);
                int getKickboard4B = PlayerPrefs.GetInt(kickboardLevel4Bronze);
                int getKickboard5G = PlayerPrefs.GetInt(kickboardLevel5Gold);
                int getKickboard5S = PlayerPrefs.GetInt(kickboardLevel5Silver);
                int getKickboard5B = PlayerPrefs.GetInt(kickboardLevel5Bronze);

                if(levelNum == 1){
                    goldScoreText.text = "" + getKickboard1G;
                    silverScoreText.text = "" + getKickboard1S;
                    bronzeScoreText.text = "" + getKickboard1B;
                }
                if(levelNum == 2){
                    goldScoreText.text = "" + getKickboard2G;
                    silverScoreText.text = "" + getKickboard2S;
                    bronzeScoreText.text = "" + getKickboard2B;
                }
                if(levelNum == 3){
                    goldScoreText.text = "" + getKickboard3G;
                    silverScoreText.text = "" + getKickboard3S;
                    bronzeScoreText.text = "" + getKickboard3B;
                }
                if(levelNum == 4){
                    goldScoreText.text = "" + getKickboard4G;
                    silverScoreText.text = "" + getKickboard4S;
                    bronzeScoreText.text = "" + getKickboard4B;
                }
                if(levelNum == 5){
                    goldScoreText.text = "" + getKickboard5G;
                    silverScoreText.text = "" + getKickboard5S;
                    bronzeScoreText.text = "" + getKickboard5B;
                }
                break;

            case 3:
                int getBike1G = PlayerPrefs.GetInt(bikeLevel1Gold);
                int getBike1S = PlayerPrefs.GetInt(bikeLevel1Silver);
                int getBike1B = PlayerPrefs.GetInt(bikeLevel1Bronze);
                int getBike2G = PlayerPrefs.GetInt(bikeLevel2Gold);
                int getBike2S = PlayerPrefs.GetInt(bikeLevel2Silver);
                int getBike2B = PlayerPrefs.GetInt(bikeLevel2Bronze);
                int getBike3G = PlayerPrefs.GetInt(bikeLevel3Gold);
                int getBike3S = PlayerPrefs.GetInt(bikeLevel3Silver);
                int getBike3B = PlayerPrefs.GetInt(bikeLevel3Bronze);
                int getBike4G = PlayerPrefs.GetInt(bikeLevel4Gold);
                int getBike4S = PlayerPrefs.GetInt(bikeLevel4Silver);
                int getBike4B = PlayerPrefs.GetInt(bikeLevel4Bronze);
                int getBike5G = PlayerPrefs.GetInt(bikeLevel5Gold);
                int getBike5S = PlayerPrefs.GetInt(bikeLevel5Silver);
                int getBike5B = PlayerPrefs.GetInt(bikeLevel5Bronze);

                if(levelNum == 1){
                    goldScoreText.text = "" + getBike1G;
                    silverScoreText.text = "" + getBike1S;
                    bronzeScoreText.text = "" + getBike1B;
                }
                if(levelNum == 2){
                    goldScoreText.text = "" + getBike2G;
                    silverScoreText.text = "" + getBike2S;
                    bronzeScoreText.text = "" + getBike2B;
                }
                if(levelNum == 3){
                    goldScoreText.text = "" + getBike3G;
                    silverScoreText.text = "" + getBike3S;
                    bronzeScoreText.text = "" + getBike3B;
                }
                if(levelNum == 4){
                    goldScoreText.text = "" + getBike4G;
                    silverScoreText.text = "" + getBike4S;
                    bronzeScoreText.text = "" + getBike4B;
                }
                if(levelNum == 5){
                    goldScoreText.text = "" + getBike5G;
                    silverScoreText.text = "" + getBike5S;
                    bronzeScoreText.text = "" + getBike5B;
                }
                break;

            case 4:
                int getCar1G = PlayerPrefs.GetInt(carLevel1Gold);
                int getCar1S = PlayerPrefs.GetInt(carLevel1Silver);
                int getCar1B = PlayerPrefs.GetInt(carLevel1Bronze);
                int getCar2G = PlayerPrefs.GetInt(carLevel2Gold);
                int getCar2S = PlayerPrefs.GetInt(carLevel2Silver);
                int getCar2B = PlayerPrefs.GetInt(carLevel2Bronze);
                int getCar3G = PlayerPrefs.GetInt(carLevel3Gold);
                int getCar3S = PlayerPrefs.GetInt(carLevel3Silver);
                int getCar3B = PlayerPrefs.GetInt(carLevel3Bronze);
                int getCar4G = PlayerPrefs.GetInt(carLevel4Gold);
                int getCar4S = PlayerPrefs.GetInt(carLevel4Silver);
                int getCar4B = PlayerPrefs.GetInt(carLevel4Bronze);
                int getCar5G = PlayerPrefs.GetInt(carLevel5Gold);
                int getCar5S = PlayerPrefs.GetInt(carLevel5Silver);
                int getCar5B = PlayerPrefs.GetInt(carLevel5Bronze);

                if(levelNum == 1){
                    goldScoreText.text = "" + getCar1G;
                    silverScoreText.text = "" + getCar1S;
                    bronzeScoreText.text = "" + getCar1B;
                }
                if(levelNum == 2){
                    goldScoreText.text = "" + getCar2G;
                    silverScoreText.text = "" + getCar2S;
                    bronzeScoreText.text = "" + getCar2B;
                }
                if(levelNum == 3){
                    goldScoreText.text = "" + getCar3G;
                    silverScoreText.text = "" + getCar3S;
                    bronzeScoreText.text = "" + getCar3B;
                }
                if(levelNum == 4){
                    goldScoreText.text = "" + getCar4G;
                    silverScoreText.text = "" + getCar4S;
                    bronzeScoreText.text = "" + getCar4B;
                }
                if(levelNum == 5){
                    goldScoreText.text = "" + getCar5G;
                    silverScoreText.text = "" + getCar5S;
                    bronzeScoreText.text = "" + getCar5B;
                }
                break;
            default:
                break;
        }
    }

    public void displayWalk(){
        mode = 1;
    }

    public void displayKickboard(){
        mode = 2;
    }

    public void displayBike(){
        mode = 3;
    }

    public void displayCar(){
        mode = 4;
    }

    public void displayLevel1(){
        levelNum = 1;
    }

    public void displayLevel2(){
        levelNum = 2;
    }

    public void displayLevel3(){
        levelNum = 3;
    }

    public void displayLevel4(){
        levelNum = 4;
    }

    public void displayLevel5(){
        levelNum = 5;
    }

    public void ReturnMainMenu(){
        SceneManager.LoadScene("MainMenuScene");
    }
}
