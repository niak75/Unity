﻿using UnityEngine;
using System.Collections;

public class Lumiere : MonoBehaviour {

	public GameObject cible;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (cible.transform);
	}
}
