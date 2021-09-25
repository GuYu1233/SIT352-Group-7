using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Core : MonoBehaviour {

	
	void Start () {
		Screen.SetResolution(1080,1920,true);
		SceneManager.LoadScene("Start");
	}
	
	
	void Update () {
		
	}
}
