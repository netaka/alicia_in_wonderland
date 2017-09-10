using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {

	int frame;
	// Use this for initialization
	void Start () {
		this.transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
		this.frame = 0;
	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		float val = 1.0f;
		float x = val * Mathf.Sin (frame / 30.0f);
		float y = 0.3f * Mathf.Sin (frame / 30.0f) + 0.9f;
		float z = val * Mathf.Cos (frame / 30.0f);
		this.transform.position = new Vector3 (x, y, z);
	}
}
