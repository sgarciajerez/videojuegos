using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transito : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D Col){
		if (Col.CompareTag ("Nivel2")) {
			Application.LoadLevel ("Escena2");
		}
		if (Col.CompareTag ("Nivel1")) {
			Application.LoadLevel ("Escena1");
		}
		if (Col.CompareTag ("Nivel3")) {
			Application.LoadLevel ("Escena3");
		}
		if (Col.CompareTag ("Nivel4")) {
			Application.LoadLevel ("Escena4");
		}
	}
}
