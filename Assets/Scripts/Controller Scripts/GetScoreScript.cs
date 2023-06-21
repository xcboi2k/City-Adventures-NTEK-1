using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GetScoreScript : MonoBehaviour
{
    public Text goldScoreText, silverScoreText, bronzeScoreText;
    private string gold, silver, bronze;

    private List<HighScoreEntry> highScoreEntryList = new List<HighScoreEntry>();
    private List<HighScoreEntry> highScoreEntryListOrder = new List<HighScoreEntry>();

    private void Awake(){
        highScoreEntryList = new List<HighScoreEntry>(){
            new HighScoreEntry{score = 100},
            new HighScoreEntry{score = 50},
            new HighScoreEntry{score = 320},
        };

        highScoreEntryListOrder  = highScoreEntryList.OrderBy(x => x.score).ToList();

        goldScoreText.text = "" + 100;
        silverScoreText.text = "" + highScoreEntryListOrder[1];
        bronzeScoreText.text = "" + highScoreEntryListOrder[2];
    }

    private class HighScoreEntry{
        public int score;
    }
}
