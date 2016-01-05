using UnityEngine;
using System.Collections;

public class EnterHouse : MonoBehaviour {

	public int charNumber=0;
	public GameObject charManager;
	public static bool spikeTerrain=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.layer == 8) {
			spikeTerrain=true;
			charManager.GetComponent<CharacterManager>().terrainAssociate[0]=true;
			charManager.GetComponent<CharacterManager>().terrainAssociate[2]=true;
			charManager.GetComponent<CharacterManager>().terrainAssociate[1]=true;
		}
		else if(col.gameObject.layer==9)
		{
			spikeTerrain=true;
			charManager.GetComponent<CharacterManager>().terrainAssociate[0]=true;
			charManager.GetComponent<CharacterManager>().terrainAssociate[2]=true;
			charManager.GetComponent<CharacterManager>().terrainAssociate[1]=true;
		}

			                                                       
			                                                           
	}
}
