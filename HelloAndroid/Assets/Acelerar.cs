﻿using UnityEngine;
using System.Collections;

public class Acelerar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
	}
}
