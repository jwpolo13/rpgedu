using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizM : MonoBehaviour {

    Renderer gmRenderer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gmRenderer = GetComponent<Renderer>();
        if (Input.GetKey(KeyCode.O))
            gmRenderer.enabled = true;
        if (Input.GetKey(KeyCode.P))
            gmRenderer.enabled = false;
    }
}
