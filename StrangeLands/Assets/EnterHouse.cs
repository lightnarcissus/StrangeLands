using UnityEngine;
using System.Collections;

public class EnterHouse : MonoBehaviour {

	public int charNumber=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.layer == 8 || col.gameObject.layer == 9) {
			Debug.Log("hi");
		}
	}
}
