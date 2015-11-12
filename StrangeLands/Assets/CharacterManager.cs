using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterManager : MonoBehaviour {

	public List<GameObject> controllers;
	private int controllerCount;
	public GameObject activeController;
	private int randController;
	// Use this for initialization
	void Start () {
		controllerCount = controllers.Count;
		for (int i=1; i<controllerCount; i++) {
			controllers[i].SetActive (false);
		}
		activeController = controllers [0];
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Random.value < 0.005) {

			randController=Random.Range (0,2);
			if(controllers[randController]!=activeController)
			{
				Debug.Log ("change active");
				activeController.SetActive (false);
				activeController=controllers[randController];
				activeController.SetActive (true);
			}

		}
	
	}
}
