using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterColScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision Col) {
        if (Col.gameObject.tag == "Gib"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            Debug.Log("Look at incoming vehicles.");
        }
    }

    private void OnTriggerEnter(Collider Col)
    {

        if (Col.gameObject.tag == "PlayerPointB")
        {
            Debug.Log("You reached Point B.");
        }

        if(Col.gameObject.tag == "Coin"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().score += 10;
            Debug.Log("Coin added to score.");
        }

        if(Col.gameObject.tag == "Road"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            Debug.Log("Why are you on the road?");
        }

        if(Col.gameObject.tag == "NoCross"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            Debug.Log("No Jaywalking");
        }
    }  
}
