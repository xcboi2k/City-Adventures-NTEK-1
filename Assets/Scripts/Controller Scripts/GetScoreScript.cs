using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScoreScript : MonoBehaviour
{
    public Text goldScoreText, silverScoreText, bronzeScoreText;
    private string gold, silver, bronze;

    private List<HighScoreEntry> highScoreEntryList;

    private void Awake(){
        highScoreEntryList = new List<HighScoreEntry>(){
            new HighScoreEntry{score = 100},
            new HighScoreEntry{score = 50},
            new HighScoreEntry{score = 320},
        };

        for (int i = 0; i < highScoreEntryList.Count; i++){
            for (int j = i + 1; j < highScoreEntryList.Count; j++){
                if(highScoreEntryList[j].score > highScoreEntryList[i].score){
                    HighScoreEntry tmp = highScoreEntryList[i];
                    highScoreEntryList[i] = highScoreEntryList[j];
                    highScoreEntryList[j] = tmp;
                }
            }
        }

        goldScoreText.text = "" + highScoreEntryList[0];
        silverScoreText.text = "" + highScoreEntryList[1];
        bronzeScoreText.text = "" + highScoreEntryList[2];
    }
    private class HighScoreEntry{
        public int score;
    }
}
