using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    public static bool notStarted = true;
	// Use this for initialization
	void Start () {

       
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("StartGame") && notStarted)
        {
            //Debug.Log("ok");
            notStarted = false;
            SceneManager.LoadScene("Main");
           // gameObject.SetActive(false);

        }
	
	}
}
