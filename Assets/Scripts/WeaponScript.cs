using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {
	
	// Projectile prefab for shooting
	public Transform shotPrefab;
	
	// Cooldown in seconds between two shots
	public float shootingRate = 0.25f;

	// Cooldown
	private float shootCooldown;

	// Use this for initialization
	void Start () {
		shootCooldown = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (shootCooldown > 0) {
			shootCooldown -= Time.deltaTime;
		}
	}

	// Shooting from another script.
	// Create a new projectile if possible
	public void Attack(bool isEnemy)
	{
		if(CanAttack)
		{
			shootCooldown = shootingRate;

			// Create a new shot
			var shotTransform = Instantiate(shotPrefab) as Transform;

			// Assign position
			shotTransform.position = transform.position;

			// The is enemy property
			ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
			if(shot != null)
			{
				shot.isEnemyShot = isEnemy;
			}

			// Make the weapon shot always towards it
			MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
			if(move != null)
			{
				// towards in 2D space is the right of the sprite
				move.direction = this.transform.right;
			}
		}
	}

	// Is the weapon ready to create a new projectile?
	public bool CanAttack
	{
		get
		{
			return shootCooldown <= 0.0f;
		}
	}
}