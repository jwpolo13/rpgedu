using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizCM : MonoBehaviour {


    Renderer gmRenderer;
    TextMesh instruction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        instruction = GetComponent<TextMesh>();
        gmRenderer = GetComponent<Renderer>();
        if (Input.GetKey(KeyCode.O))
            gmRenderer.enabled = true;
        if (Input.GetKey(KeyCode.P))
            gmRenderer.enabled = false;
        if (Input.GetKey(KeyCode.L))
            instruction.text = "Correct! Great job.";
    }
}
