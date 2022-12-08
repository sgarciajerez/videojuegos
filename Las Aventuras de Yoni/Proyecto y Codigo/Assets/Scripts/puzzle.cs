using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour {
	public GameObject cubo1;
	public GameObject cubo2;
	public GameObject cubo3;
	public GameObject plataforma;
	public AudioSource cofre;
	public AudioSource llave;
	public ParticleSystem bomba;
	private float Damage = 100f;


	// Use this for initialization
	void Start () {
		cubo1.SetActive (true);
		cubo2.SetActive (false);
		cubo3.SetActive (false);
		plataforma.SetActive (false);
		bomba.Stop ();
		cofre.Stop ();
		llave.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D otro){
		if (otro.CompareTag ("pulsador")) {
			cubo1.SetActive (false);
			cubo2.SetActive (true);
			plataforma.SetActive (true);
			bomba.Play ();
			cofre.Play ();
		}
			
		if (otro.CompareTag ("gema")) {
			PlayerControl.Health = Damage;
			Destroy (otro.gameObject);
		
		}
		if (otro.CompareTag ("llave")) {
			cubo3.SetActive (true);
			cubo2.SetActive (false);
			llave.Play ();
		}
	}
}
