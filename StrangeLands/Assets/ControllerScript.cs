using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	public Color fogColor;
	public bool fogActive=true;
	public Color camColor;

	// Use this for initialization
	void Start () {
	
	}

	void OnEnable()
	{
		RenderSettings.fogColor = fogColor;
		transform.GetChild (0).gameObject.GetComponent<Camera> ().backgroundColor = camColor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
