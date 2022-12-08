using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

	public float Damage = 100f;
	public float lifeTime = 1f;

	// Use this for initialization
	void Start () {
		Invoke ("Die", lifeTime);
		
	}
	
	// Update is called once per frame
	void Update () {
	}
		void OnTriggerEnter2D (Collider2D otro) {
			if (otro.CompareTag ("Player")){
				PlayerControl.Health = PlayerControl.Health - Damage;
			Die ();
			}
		}
		public void Die (){
			Destroy (gameObject);
		}
}
