using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPedColScript : MonoBehaviour
{
    CharacterController controller;
    Animator animator;

    public GameObject body;
    private AgentScript agentScript;

	private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = body.GetComponent<Animator>();
        agentScript = GetComponent<AgentScript>();
    }

    private void Update() {
        if(agentScript.isWalking == true){
            animator.SetBool("Walk", true);
        }
        else{
            animator.SetBool("Walk", false);
        }
    }

    private void OnTriggerEnter(Collider Col) {
        if(Col.gameObject.tag == "Road"){
            Destroy(gameObject);
            Debug.Log("No Jaywalking.");
        }
    }
}
