﻿using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	/// <summary>
	/// Damage inflicted
	/// </summary>
	public int damage = 1;

	/// <summary>
	/// Projectile damage player or enermies?
	/// </summary>
	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {
		// Limited time to live to avoid any leak
		Destroy (gameObject, 5); // 5sec
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}