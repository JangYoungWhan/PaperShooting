using UnityEngine;
using System.Collections;

public class SoundEffectsHelper : MonoBehaviour {

	// Singleton
	public static SoundEffectsHelper Instance;

	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake()
	{
		// Register the singleton
		if(Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}

	public void MakeExplosionSound()
	{
		MakeSound (explosionSound);
	}

	public void MakePlayerShotSound()
	{
		MakeSound (playerShotSound);
	}

	public void MakeEnemyShotSound()
	{
		MakeSound (enemyShotSound);
	}

	/// <summary>
	/// Play a given sound
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clipk, position doesn't matter.
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	}
}
