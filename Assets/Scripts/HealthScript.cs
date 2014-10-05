using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	/// <summary>
	/// Total hitpoints
	/// </summary>
	public int hp = 1;

	/// <summary>
	/// Enemy or Player?
	/// </summary>
	public bool isEnemy = true;

	public void Damage(int damageCount)	{
		hp -= damageCount;

		if (hp <= 0) {
			// Effect
			SpecialEffectsHelper.Instance.Explosion(transform.position);

			// Sound
			SoundEffectsHelper.Instance.MakeExplosionSound();

			// Dead!
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D otherCollider)	{
		// Is this a shot?
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript> ();
		if (shot != null) {
			// Avoid friendly fire
			if (shot.isEnemyShot != isEnemy) {
				Damage (shot.damage);

				// Destroy the shot
				// Remember to always target the game object,
				// otherwise you will just remove the script
				Destroy (shot.gameObject);
			}
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}