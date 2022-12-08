using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morir : MonoBehaviour {

	public float Damage = 10f;
	private float Death = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerControl.Health == Death) {
			Application.LoadLevel ("Escena1");
		}

		
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.CompareTag ("Killzone") && PlayerControl.PlayerInstance != null) {
			PlayerControl.Health = PlayerControl.Health - Damage * Time.deltaTime;
		}

	}
			
}
