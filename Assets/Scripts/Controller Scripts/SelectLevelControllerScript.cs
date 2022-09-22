using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevelControllerScript : MonoBehaviour
{
    private const string selectedMode = "Selected Mode";
    private const string selectedLevel = "Selected Level";

    [Header("Mode Objects")]
    public GameObject walkLevels;
    public GameObject kickboardLevels;
    public GameObject bikeLevels;
    public GameObject carLevels;

    private void Start() {
        int getMode = PlayerPrefs.GetInt(selectedMode);

        if(getMode == 1){
            walkLevels.SetActive(true);
        }
        if(getMode == 2){
            kickboardLevels.SetActive(true);
        }
        if(getMode == 3){
            bikeLevels.SetActive(true);
        }
        if(getMode == 4){
            carLevels.SetActive(true);
        }

    }

    public void SelectedLevel1(){
        PlayerPrefs.SetInt(selectedLevel, 1);
        SceneManager.LoadScene("GameScene");
    }

    public void SelectedLevel2(){
        PlayerPrefs.SetInt(selectedLevel, 2);
        SceneManager.LoadScene("GameScene");
    }

    public void SelectedLevel3(){
        PlayerPrefs.SetInt(selectedLevel, 3);
        SceneManager.LoadScene("GameScene");
    }

    public void SelectedLevel4(){
        PlayerPrefs.SetInt(selectedLevel, 4);
        SceneManager.LoadScene("GameScene");
    }

    public void SelectedLevel5(){
        PlayerPrefs.SetInt(selectedLevel, 5);
        SceneManager.LoadScene("GameScene");
    }

    public void Back(){
        SceneManager.LoadScene("SelectModeScene");
    }
}
