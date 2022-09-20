using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObserverScript : MonoBehaviour
{
    [HideInInspector]
    public int currentVehicles = 0;
    [HideInInspector]
    public int currentPeds = 0;

    GameObject[] AIVehicles;
    GameObject[] AIPeds;
        

    private void Update() {
        AIVehicles = GameObject.FindGameObjectsWithTag("Gib");
        AIPeds = GameObject.FindGameObjectsWithTag("Unit");

        currentVehicles = AIVehicles.Length;
        currentPeds = AIPeds.Length;
    }

    void OnGUI()
    {
        GUI.color = Color.black;
            GUI.Label(new Rect(10, 30, 200, 20), "Current Vehicles: " + currentVehicles);
            GUI.Label(new Rect(10, 60, 200, 20), "Current Peds: " + currentPeds);
    }
}
