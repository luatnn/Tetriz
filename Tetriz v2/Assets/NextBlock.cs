﻿using UnityEngine;
using System.Collections;

public class NextBlock : MonoBehaviour {

	// Groups
	public GameObject[] blocks;
	GameObject block;
	
	public void showNext(int i) {
		// Destroys previous block
		if (block != null)
			Destroy (block);
		// Spawn Group at current Position
		block = Instantiate(blocks[i],
		                    transform.position,
		                    Quaternion.identity) as GameObject;
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
