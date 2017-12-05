using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeM : MonoBehaviour {

    Renderer gmRenderer;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        gmRenderer = GetComponent<Renderer>();
        if (Input.GetKey(KeyCode.B))
            gmRenderer.enabled = true;
        if (Input.GetKey(KeyCode.N))
            gmRenderer.enabled = false;
    }
}
