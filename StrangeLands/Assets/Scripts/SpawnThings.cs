using UnityEngine;
using System.Collections;

public class SpawnThings : MonoBehaviour {

	public GameObject poles;
	public GameObject human;
	// Use this for initialization
	void Start () {
	
		for (int i=-180; i<280; i++) {
			for(int j=100;j<570;j++)
			{
				if(Random.value<0.001)
					Instantiate (poles,new Vector3((float)i,-11.9f,(float)j),Quaternion.identity);
				if(Random.value<0.0005)
					Instantiate (human,new Vector3((float)i,-12.23f,(float)j),Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
