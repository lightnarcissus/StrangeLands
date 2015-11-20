using UnityEngine;
using System.Collections;

public class EnterHouse : MonoBehaviour {

	public int charNumber=0;
	public GameObject charManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.layer == 8) {
			charManager.GetComponent<CharacterManager>().terrainAssociate[0]=true;
		}
		else if(col.gameObject.layer==9)
		{
			charManager.GetComponent<CharacterManager>().terrainAssociate[1]=true;
		}

			                                                       
			                                                           
	}
}
