using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerSceneOne : MonoBehaviour {

	GameObject jacob, sophia, anniah;
	Transform camera1;

	Animation jacobWalk, jacobIdle, sophiaIdle, anniahIdle;

	// Use this for initialization
	void Start () {
		jacob = GameObject.Find ("Jacob");
		sophia = GameObject.Find ("Sophia");
		anniah = GameObject.Find ("Anniah");	

		camera1 = Camera.main.transform;



		//jacob.transform.position -= jacob.transform.forward;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
