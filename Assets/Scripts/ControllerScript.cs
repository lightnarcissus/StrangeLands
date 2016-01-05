using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	public Color fogColor;
	public bool fogActive=true;
	public Color camColor;

	public GameObject other1;
	public GameObject other2;
	// Use this for initialization
	void Start () {

		InvokeRepeating ("CheckDistance", 1f,2f);
	
	}

	void OnEnable()
	{
		RenderSettings.fogColor = fogColor;
		transform.GetChild (0).gameObject.GetComponent<Camera> ().backgroundColor = camColor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CheckDistance()
	{
		if (EnterHouse.spikeTerrain) {
			if (Vector3.Distance (other1.transform.position, transform.position) < 5f) {

				Debug.Log ("collided with other1");
				EnterHouse.spikeTerrain=false;
			}

			if (Vector3.Distance (other2.transform.position, transform.position) < 5f) {
				Debug.Log ("collided with other2");
				EnterHouse.spikeTerrain=false;
			}
		}

	}
}
