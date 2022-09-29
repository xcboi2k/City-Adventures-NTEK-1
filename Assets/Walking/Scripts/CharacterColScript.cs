using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterColScript : MonoBehaviour
{
    public AudioSource playerCharacterAudio;
    public AudioClip coinClip, finishPointClip;
    public Text reminderText;

    private void OnCollisionEnter(Collision Col) {
        if (Col.gameObject.tag == "Gib"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
        }
    }

    private void OnTriggerEnter(Collider Col)
    {

        if (Col.gameObject.tag == "Finish Point")
        {
            playerCharacterAudio.PlayOneShot(finishPointClip);
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().stopCountingScore = true;
        }

        if(Col.gameObject.tag == "Coin"){
            playerCharacterAudio.PlayOneShot(coinClip);
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().coin += 10;
            Destroy(Col.gameObject);
        }

        if(Col.gameObject.tag == "Road"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            reminderText.text = "You can only cross the road by using the pedestrian crossing.";
        }

        if(Col.gameObject.tag == "NoCross"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            reminderText.text = "Crossing the road while the light is green is jaywalking.";
        }
    }  
}
