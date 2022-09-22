using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarColScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision Col) {
        if (Col.gameObject.tag == "Gib"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            Debug.Log("Look at other vehicles.");
        }

        if (Col.gameObject.tag == "Unit"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            Debug.Log("Watch out on pedestrians.");
        }
    }

    private void OnTriggerEnter(Collider Col)
    {

        if (Col.gameObject.tag == "Finish Point")
        {
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().isGameFinished = true;
            Debug.Log("You reached Point B.");
        }

        if(Col.gameObject.tag == "Coin"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().coin += 10;
            Debug.Log("Coin added to score.");
        }

        if(Col.gameObject.tag == "Sidewalk"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            Debug.Log("Why are you on the sidewalk?");
        }

        if(Col.gameObject.tag == "Cross"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().ticketNum += 1;
            Debug.Log("Peds crossing.");
        }
    }  
}
