using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCarColScript : MonoBehaviour
{
    public AudioSource playerCarAudio;
    public AudioClip coinClip, finishPointClip;
    public Text reminderText;

    private void OnCollisionEnter(Collision Col) {
        if (Col.gameObject.tag == "Gib"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().isPlayerAccident = true;
        }

        if (Col.gameObject.tag == "Unit"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().isPlayerAccident = true;
        }
    }

    private void OnTriggerEnter(Collider Col)
    {

        if (Col.gameObject.tag == "Finish Point")
        {
            playerCarAudio.PlayOneShot(finishPointClip);
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().stopCountingScore = true;
        }

        if(Col.gameObject.tag == "Coin"){
            playerCarAudio.PlayOneShot(coinClip);
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().coin += 10;
            Destroy(Col.gameObject);
        }

        if(Col.gameObject.tag == "Sidewalk"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            reminderText.text = "Cars and bikes cannot drive in sidewalks.";
        }

        if(Col.gameObject.tag == "Cross"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            reminderText.text = "Always check the traffic light. When it is red, pedestrians are crossing.";
        }
    }  
}
