using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VikingM : MonoBehaviour {

    Renderer gmRenderer;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        gmRenderer = GetComponent<Renderer>();
        if (Input.GetKey(KeyCode.Z))
            gmRenderer.enabled = true;
        if (Input.GetKey(KeyCode.X))
            gmRenderer.enabled = false;

    }
}
