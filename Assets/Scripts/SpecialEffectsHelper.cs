using UnityEngine;
using System.Collections;

public class SpecialEffectsHelper : MonoBehaviour {

	// Singleton
	public static SpecialEffectsHelper Instance;

	public ParticleSystem smokeEffect;
	public ParticleSystem fireEffect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake()
	{
		if (Instance != null)
			Debug.LogError("Multiple instances of SpecialEffectsHelper!");

		Instance = this;
	}

	// Create an explosion at the given location
	public void Explosion(Vector3 position)
	{
		// Smoke on the water
		instantiate (smokeEffect, position);

		// Fire in the sky
		instantiate (fireEffect, position);

	}

	private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate (
			prefab,
			position,
			Quaternion.identity
				) as ParticleSystem;

		// Make sure it will be destroyed
		Destroy (
			newParticleSystem.gameObject,
			newParticleSystem.startLifetime
				);

		return newParticleSystem;
	}
}
