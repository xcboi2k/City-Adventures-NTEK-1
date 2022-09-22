using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectModeControllerScript : MonoBehaviour
{
    private const string selectedMode = "Selected Mode";
    public void SelectedWalk(){
        PlayerPrefs.SetInt(selectedMode, 1);
        SceneManager.LoadScene("SelectLevelScene");
    }

    public void SelectedKickboard(){
        PlayerPrefs.SetInt(selectedMode, 2);
        SceneManager.LoadScene("SelectLevelScene");
    }

    public void SelectedBike(){
        PlayerPrefs.SetInt(selectedMode, 3);
        SceneManager.LoadScene("SelectLevelScene");
    }

    public void SelectedCar(){
        PlayerPrefs.SetInt(selectedMode, 4);
        SceneManager.LoadScene("SelectLevelScene");
    }

    public void Back(){
        SceneManager.LoadScene("MainMenuScene");
    }
}
