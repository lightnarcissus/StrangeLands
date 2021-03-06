﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CharacterManager : MonoBehaviour {

	public List<GameObject> controllers;
	public bool[] terrainAssociate;
	private int controllerCount;
	public GameObject activeController;
	private int randController;
	public AudioClip[] clips;
	public static int transCount=0;
	public GameObject altSource;
	private float timer=0f;
	public GameObject upsideDownTerrain;
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
				if(EnterHouse.spikeTerrain)
				{
				spikyTerrain.SetActive (true);
				plainTerrain.SetActive (true);
				}
				else
				{
					plainTerrain.SetActive (true);
					if(Random.value<0.5f)
					upsideDownTerrain.SetActive (true);
					else 
						upsideDownTerrain.SetActive (false);
					if(Random.value<0.5f)
						spikyTerrain.SetActive (true);
					else
						spikyTerrain.SetActive (false);
				}
			}

			GetComponent<AudioSource> ().PlayOneShot (clips [randController]);

			if(Random.value < 0.5f)
			{
				altSource.GetComponent<AudioSource>().PlayOneShot (clips[Random.Range(3,6)]);
			}

		}



        if (transCount > 13 && transCount<25) {
        spikyTerrain.SetActive (true);
			plainTerrain.SetActive (false);
		}

		if (transCount > 25) {
			spikyTerrain.GetComponent<TerrainCollider>().enabled=false;
			timer+=Time.deltaTime;
		}

		if (timer > 10f || Input.GetKeyDown(KeyCode.Escape)) {
            timer = 0f;
            StartManager.notStarted = true;
            SceneManager.LoadScene("StartGame");
         //   gameObject.SetActive(false);
        }
	
	}

}
