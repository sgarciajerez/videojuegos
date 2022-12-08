using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoTurret : MonoBehaviour {

	private Transform disparo;
	public float velocidadDisparo = 10f;

	void Awake (){
		disparo = GetComponent<Transform> ();
	}

	// Use this for initialization
	void Start () {
		//disparo = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		disparo.position = disparo.position + disparo.forward * velocidadDisparo * Time.deltaTime;	
	}
}
