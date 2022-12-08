using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAlChocar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D otro){
		if (otro.CompareTag ("obstaculo")) {
			Destroy (gameObject);
		}
	}
}
