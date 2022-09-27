using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHighScoreScript : MonoBehaviour
{
    private const string selectedMode = "Selected Mode";
    private const string selectedLevel = "Selected Level";

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

    private int finalScore;
    void Update()
    {
        if(GameObject.Find("Game Controller").GetComponent<GameControllerScript>().isGameFinished == true){
            int getMode = PlayerPrefs.GetInt(selectedMode);
            int getLevel = PlayerPrefs. GetInt(selectedLevel);

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

            finalScore = GameObject.Find("Game Controller").GetComponent<GameControllerScript>().finalScore;

            if(getMode == 1){
                switch (getLevel)
                {
                    case 1:
                        if(getWalk1G < finalScore || getWalk1G == 0){
                            PlayerPrefs.SetInt(walkLevel1Gold, finalScore);
                        }
                        else if(getWalk1S < finalScore){
                            PlayerPrefs.SetInt(walkLevel1Silver, finalScore);
                        }
                        else if(getWalk1B < finalScore){
                            PlayerPrefs.SetInt(walkLevel1Bronze, finalScore);
                        }
                        break;
                    case 2:
                        if(getWalk2G < finalScore){
                            PlayerPrefs.SetInt(walkLevel2Gold, finalScore);
                        }
                        else if(getWalk2S < finalScore){
                            PlayerPrefs.SetInt(walkLevel2Silver, finalScore);
                        }
                        else if(getWalk2B < finalScore){
                            PlayerPrefs.SetInt(walkLevel2Bronze, finalScore);
                        }
                        break;
                    case 3:
                        if(getWalk3G < finalScore){
                            PlayerPrefs.SetInt(walkLevel3Gold, finalScore);
                        }
                        else if(getWalk3S < finalScore){
                            PlayerPrefs.SetInt(walkLevel3Silver, finalScore);
                        }
                        else if(getWalk3B < finalScore){
                            PlayerPrefs.SetInt(walkLevel3Bronze, finalScore);
                        }
                        break;
                    case 4:
                        if(getWalk4G < finalScore){
                            PlayerPrefs.SetInt(walkLevel4Gold, finalScore);
                        }
                        else if(getWalk4S < finalScore){
                            PlayerPrefs.SetInt(walkLevel4Silver, finalScore);
                        }
                        else if(getWalk4B < finalScore){
                            PlayerPrefs.SetInt(walkLevel4Bronze, finalScore);
                        }
                        break;
                    case 5:
                        if(getWalk5G < finalScore){
                            PlayerPrefs.SetInt(walkLevel5Gold, finalScore);
                        }
                        else if(getWalk5S < finalScore){
                            PlayerPrefs.SetInt(walkLevel5Silver, finalScore);
                        }
                        else if(getWalk5B < finalScore){
                            PlayerPrefs.SetInt(walkLevel5Bronze, finalScore);
                        }
                        break;
                    default:
                        break;
                }
            }

            if(getMode == 2){
                switch (getLevel)
                {
                    case 1:
                        if(getKickboard1G < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel1Gold, finalScore);
                        }
                        else if(getKickboard1S < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel1Silver, finalScore);
                        }
                        else if(getKickboard1B < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel1Bronze, finalScore);
                        }
                        break;
                    case 2:
                        if(getKickboard2G < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel2Gold, finalScore);
                        }
                        else if(getKickboard2S < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel1Silver, finalScore);
                        }
                        else if(getKickboard2B < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel2Bronze, finalScore);
                        }
                        break;
                    case 3:
                        if(getKickboard3G < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel3Gold, finalScore);
                        }
                        else if(getKickboard3S < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel3Silver, finalScore);
                        }
                        else if(getKickboard3B < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel3Bronze, finalScore);
                        }
                        break;
                    case 4:
                        if(getKickboard4G < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel4Gold, finalScore);
                        }
                        else if(getKickboard4S < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel4Silver, finalScore);
                        }
                        else if(getKickboard4B < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel4Bronze, finalScore);
                        }
                        break;
                    case 5:
                        if(getKickboard5G < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel5Gold, finalScore);
                        }
                        else if(getKickboard5S < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel5Silver, finalScore);
                        }
                        else if(getKickboard5B < finalScore){
                            PlayerPrefs.SetInt(kickboardLevel5Bronze, finalScore);
                        }
                        break;
                    default:
                        break;
                }
            }

            if(getMode == 3){
                switch (getLevel)
                {
                    case 1:
                        if(getBike1G < finalScore){
                            PlayerPrefs.SetInt(bikeLevel1Gold, finalScore);
                        }
                        else if(getBike1S < finalScore){
                            PlayerPrefs.SetInt(bikeLevel1Silver, finalScore);
                        }
                        else if(getBike1B < finalScore){
                            PlayerPrefs.SetInt(bikeLevel1Bronze, finalScore);
                        }
                        break;
                    case 2:
                        if(getBike2G < finalScore){
                            PlayerPrefs.SetInt(bikeLevel2Gold, finalScore);
                        }
                        else if(getBike2S < finalScore){
                            PlayerPrefs.SetInt(bikeLevel2Silver, finalScore);
                        }
                        else if(getBike2B < finalScore){
                            PlayerPrefs.SetInt(bikeLevel2Bronze, finalScore);
                        }
                        break;
                    case 3:
                        if(getBike3G < finalScore){
                            PlayerPrefs.SetInt(bikeLevel3Gold, finalScore);
                        }
                        else if(getBike3S < finalScore){
                            PlayerPrefs.SetInt(bikeLevel3Silver, finalScore);
                        }
                        else if(getBike3B < finalScore){
                            PlayerPrefs.SetInt(bikeLevel3Bronze, finalScore);
                        }
                        break;
                    case 4:
                        if(getBike4G < finalScore){
                            PlayerPrefs.SetInt(bikeLevel4Gold, finalScore);
                        }
                        else if(getBike4S < finalScore){
                            PlayerPrefs.SetInt(bikeLevel4Silver, finalScore);
                        }
                        else if(getBike4B < finalScore){
                            PlayerPrefs.SetInt(bikeLevel4Bronze, finalScore);
                        }
                        break;
                    case 5:
                        if(getBike5G < finalScore){
                            PlayerPrefs.SetInt(bikeLevel5Gold, finalScore);
                        }
                        else if(getBike5S < finalScore){
                            PlayerPrefs.SetInt(bikeLevel5Silver, finalScore);
                        }
                        else if(getBike5B < finalScore){
                            PlayerPrefs.SetInt(bikeLevel5Bronze, finalScore);
                        }
                        break;
                    default:
                        break;
                }
            }

            if(getMode == 4){
                switch (getLevel)
                {
                    case 1:
                        if(getCar1G < finalScore){
                            PlayerPrefs.SetInt(carLevel1Gold, finalScore);
                        }
                        else if(getCar1S < finalScore){
                            PlayerPrefs.SetInt(carLevel1Silver, finalScore);
                        }
                        else if(getCar1B < finalScore){
                            PlayerPrefs.SetInt(carLevel1Bronze, finalScore);
                        }
                        break;
                    case 2:
                        if(getCar2G < finalScore){
                            PlayerPrefs.SetInt(carLevel2Gold, finalScore);
                        }
                        else if(getCar2S < finalScore){
                            PlayerPrefs.SetInt(carLevel2Silver, finalScore);
                        }
                        else if(getCar2B < finalScore){
                            PlayerPrefs.SetInt(carLevel2Bronze, finalScore);
                        }
                        break;
                    case 3:
                        if(getCar3G < finalScore){
                            PlayerPrefs.SetInt(carLevel3Gold, finalScore);
                        }
                        else if(getCar3S < finalScore){
                            PlayerPrefs.SetInt(carLevel3Silver, finalScore);
                        }
                        else if(getCar3B < finalScore){
                            PlayerPrefs.SetInt(carLevel3Bronze, finalScore);
                        }
                        break;
                    case 4:
                        if(getCar4G < finalScore){
                            PlayerPrefs.SetInt(carLevel4Gold, finalScore);
                        }
                        else if(getCar4S < finalScore){
                            PlayerPrefs.SetInt(carLevel4Silver, finalScore);
                        }
                        else if(getCar4B < finalScore){
                            PlayerPrefs.SetInt(carLevel4Bronze, finalScore);
                        }
                        break;
                    case 5:
                        if(getCar5G < finalScore){
                            PlayerPrefs.SetInt(carLevel5Gold, finalScore);
                        }
                        else if(getCar5S < finalScore){
                            PlayerPrefs.SetInt(carLevel5Silver, finalScore);
                        }
                        else if(getCar5B < finalScore){
                            PlayerPrefs.SetInt(carLevel5Bronze, finalScore);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
