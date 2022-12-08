using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionMunicion : MonoBehaviour {
	
	public GameObject disparo;
	private Transform canyon;

	// Use this for initialization
	void Start () {
		canyon = GetComponent<Transform> ();
		FireAmmo ();
		
	}
	public void FireAmmo(){
		GameObject obj = Instantiate (disparo, canyon.position, canyon.rotation) as GameObject;
		Invoke ("FireAmmo", 3);
	}
}