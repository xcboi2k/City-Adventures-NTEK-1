using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVehicleColScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision Col) {
        if (Col.gameObject.tag == "Player"){
            GameObject.Find("Game Controller").GetComponent<GameControllerScript>().isPlayerAccident = true;
        }

        if (Col.gameObject.tag == "Unit"){
            Destroy(Col.gameObject);
            Destroy(gameObject);
            Debug.Log("AI Vehicle killed Pedestrian.");
        }
    }

    private void OnTriggerEnter(Collider Col) {
        if(Col.gameObject.tag == "Sidewalk"){
            Destroy(gameObject);
            Debug.Log("AI Vehicle out of bounds.");
        }
    }
}
