﻿using UnityEngine;
using System.Collections;

public class KeyPiece : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void Use()
    {
        GameObject.FindWithTag("MainCamera").GetComponent<FancyPantsScript>().UpdateKey();
        Destroy(this.gameObject);
    }
}
