using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3 : MonoBehaviour {
	public GameObject cofre1;
	public GameObject cofre2;
	public GameObject palabra1;
	public GameObject palabra2;
	public AudioSource sintonia;
	public AudioSource cofre;
	public AudioSource cofrefinal;


	// Use this for initialization
	void Start () {
		cofre1.SetActive (true);
		cofre2.SetActive (false);
		palabra1.SetActive (false);
		palabra2.SetActive (false);
		sintonia.Play ();
		cofre.Stop ();
		cofrefinal.Stop ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D otro){
		if (otro.CompareTag ("Cofre1")) {
			cofre1.SetActive (false);
			cofre2.SetActive (true);
			palabra1.SetActive (true);
			cofre.Play ();
		}

		if (otro.CompareTag ("Cofre2")) {
			cofre2.SetActive (false);
			palabra2.SetActive (true);
			palabra1.SetActive (false);
			sintonia.Stop ();
			cofrefinal.Play ();
		}
	}
}