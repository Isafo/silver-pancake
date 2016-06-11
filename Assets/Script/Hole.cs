﻿using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {        
        if (other.transform.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            other.GetComponent<Player>().holesPassed++;
        }
    }
}
