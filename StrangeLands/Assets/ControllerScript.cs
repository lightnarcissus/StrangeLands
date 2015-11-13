using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	public Color fogColor;
	public bool fogActive=true;

	// Use this for initialization
	void Start () {
	
	}

	void Awake()
	{
		RenderSettings.fogColor = fogColor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
