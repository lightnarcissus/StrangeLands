using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterManager : MonoBehaviour {

	public List<GameObject> controllers;
	public bool[] terrainAssociate;
	private int controllerCount;
	public GameObject activeController;
	private int randController;
	public AudioClip[] clips;
	public static int transCount=0;

	private float timer=0f;

	public GameObject plainTerrain;
	public GameObject spikyTerrain;
	// Use this for initialization
	void Start () {
		UnityEngine.Cursor.visible = false;
		controllerCount = controllers.Count;
		for (int i=1; i<controllerCount; i++) {
			controllers[i].SetActive (false);
		}
		activeController = controllers [0];
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Random.value < 0.002) {

			randController=Random.Range (0,3);

			if(controllers[randController]!=activeController)
			{
				transCount++;
				//Debug.Log ("change active");
				activeController.SetActive (false);
				activeController=controllers[randController];
				activeController.SetActive (true);
			}
			if(terrainAssociate[randController])
			{
				spikyTerrain.SetActive (true);
				plainTerrain.SetActive (false);
			}
			else
			{
				plainTerrain.SetActive (true);
				spikyTerrain.SetActive (false);
			}
			GetComponent<AudioSource> ().PlayOneShot (clips [randController]);

		}

		if (transCount > 13 && transCount<25) {
			spikyTerrain.SetActive (true);
			plainTerrain.SetActive (false);
		}

		if (transCount > 25) {
			spikyTerrain.GetComponent<TerrainCollider>().enabled=false;
			timer+=Time.deltaTime;
		}

		if (timer > 10f) {
			Application.Quit ();
		}
	
	}

}
