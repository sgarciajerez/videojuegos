using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {
	public GameObject cubo1;
	public GameObject cubo2;
	public GameObject cubo3;
	public ParticleSystem bomba;
	public AudioSource objeto;
	private float Damage = 100f;


	// Use this for initialization
	void Start () {
		cubo1.SetActive (true);
		cubo2.SetActive (false);
		cubo3.SetActive (true);
		bomba.Stop ();
		objeto.Stop ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D otro){
		if (otro.CompareTag ("pulsador")) {
			cubo1.SetActive (false);
			cubo2.SetActive (true);
			cubo3.SetActive (false);
			bomba.Play ();
			objeto.Play ();
		}

		if (otro.CompareTag ("gema")) {
			PlayerControl.Health = Damage;
			Destroy (otro.gameObject);
		}
	}
}
