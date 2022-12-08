using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {

	private Transform plataforma;
	private Vector2 posicionOriginal;
	public Vector2 moverEjes = Vector2.zero;
	public float distancia = 3f;

	// Use this for initialization
	void Start () {

		plataforma = GetComponent<Transform> ();
		posicionOriginal = plataforma.position;

	}

	// Update is called once per frame
	void Update () {

		plataforma.position = posicionOriginal + moverEjes * Mathf.PingPong (Time.time, distancia);

	}
}
