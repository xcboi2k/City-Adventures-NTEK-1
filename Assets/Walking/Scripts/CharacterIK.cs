using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIK : MonoBehaviour {

    Animator animator;

    public GameObject lookAt;

    void Awake ()
    {
        animator = GetComponent<Animator>();
    }

	void OnAnimatorIK(int layerIndex)
    {
        animator.SetLookAtWeight(1f, 0.1f, 0.9f, 1.0f, 0.5f);
        animator.SetLookAtPosition(lookAt.transform.position);
    }
}
