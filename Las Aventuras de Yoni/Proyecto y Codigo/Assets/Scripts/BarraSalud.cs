using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraSalud : MonoBehaviour {

	private RectTransform esteTransform = null;
	public float maxSpeed = 10f;

	// Use this for initialization
	void Awake (){
		esteTransform = GetComponent <RectTransform> ();
	}

	void Start () {
		if (PlayerControl.PlayerInstance != null)
			esteTransform.sizeDelta = new Vector2 (Mathf.Clamp (PlayerControl.Health, 0, 100), esteTransform.sizeDelta.y);
		}
	
	// Update is called once per frame
	void Update () {
		float HealthUpdate = 0f;

		if (PlayerControl.PlayerInstance != null)
			HealthUpdate = Mathf.MoveTowards (esteTransform.rect.width, PlayerControl.Health, maxSpeed);
		esteTransform.sizeDelta = new Vector2 (Mathf.Clamp (HealthUpdate, 0, 100), esteTransform.sizeDelta.y);
		
	}
}
