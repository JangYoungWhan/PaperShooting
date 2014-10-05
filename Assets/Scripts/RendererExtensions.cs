using UnityEngine;
//using System.Collections;

public static class RendererExtensions {// : MonoBehaviour {

	public static bool IsVisibleFrom(this Renderer renderer, Camera camera) {
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes (camera);
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
	/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/
}
