﻿using UnityEngine;
using System.Collections;

public class cubeSpin : MonoBehaviour {

	float spinSpeed;

	// Use this for initialization
	void Start () {
		spinSpeed = Random.Range (90f, 250f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, Time.deltaTime * spinSpeed, 0f);
	}
}
