using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerSceneOne : MonoBehaviour {

	public float timeScale = 1;

	GameObject jacob, sophia, anniah, narrator;

	Camera camera1, camera2, camera3;

	float time;

	Animation jacobWalk, jacobIdle, sophiaIdle, anniahIdle;

	public Animator jacobAnimator, narratorAnimator, sophiaAnimator, anniahAnimator;

	AudioSource narratorAudio, jacobAudio, sophiaAudio;

	AudioClip gettingWorseJacob, gettingWorseAnniah;

	bool askMedicine;
	bool grabMedicine;
	bool goToAnniah;

	// Use this for initialization
	void Start () {
		// Characters
		jacob = GameObject.Find ("Jacob");
		sophia = GameObject.Find ("Sophia");
		anniah = GameObject.Find ("Anniah");	
		narrator = GameObject.Find ("Narrator");

		// Audio
		narratorAudio = narrator.GetComponent<AudioSource>();

		// Camera
		camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
		camera2 = GameObject.Find ("Camera2").GetComponent<Camera>();
		camera3 = GameObject.Find ("Camera3").GetComponent<Camera>();

	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = timeScale;
		time = Time.time;

		/* Beginning of play */

		/* Scene One */ 

//		 Narrator starts talking

		if (time > 2.0f && time <  2.0f + Time.deltaTime) {
			narratorAudio.Play ();
		}

//		 Camera switches to views of Anniah, Jacob, and Sophia 

		// View Jacob
		if (time > 8.0f && time < 8.0f + Time.deltaTime) {
			camera2.depth = -1;
			camera1.depth = -2;
		}
		// View Sophia
		if (time > 15.0f && time < 15.0f + Time.deltaTime) {
			camera2.depth = -3;
			camera1.depth = -2;
			camera3.depth = -1;

		}

//		 Jacob asks where the medicine is. 
//		 Sophia gives it to him. Says its right here.
		if (time > 19f && time < 19f + Time.deltaTime) {
//			jacob.transform.rotation = Quaternion.Euler (0, -90, 0);
//			askMedicine = true;
			jacobAnimator.SetBool("AskMedicine", true);
			// Previous animation has to have exit time.
			jacobAnimator.SetBool ("LeaveSophia", true);

		}
			
//		 Jacob says Anniah is gettings worse and gives spoonful of medicine to Anniah

//		 Sophia agrees

//		 Jacob says he wants a boy

//		 Sophia responds shocked and angry

//		 They keep talking 

//		 Jacob gets his stuff and leaves the house.



// 		 Go to Scene Two

	}

//	void GrabMedicine() {
//		if (grabMedicine) {
//			jacob.transform.Translate (Vector3.forward * Time.deltaTime);
//		}
//		if (jacob.transform.position.x <= -3.95f) {
//			grabMedicine = false;
//			askMedicine = false;
//			goToAnniah = true;
//		}
//	}

//	void GoToAnniah() {
//		jacob.transform.Translate (Vector3.forward * Time.deltaTime);
//	}
//		
//	void TurnJacob() {
//		while (jacob.transform.rotation.eulerAngles.y > 90) {
//			jacob.transform.rotation = Quaternion.Lerp (jacob.transform.rotation, Quaternion.Euler (0, 90, 0), 1 * Time.deltaTime);
//		}
//	}


}
