using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerSceneOne : MonoBehaviour {

	public float timeScale = 1;

	public static bool finishedScene1;

	GameObject jacob, sophia, anniah, narrator;

	Camera camera1, camera2, camera3;

	public float time;

	Animation jacobWalk, jacobIdle, sophiaIdle, anniahIdle;

	public Animator jacobAnimator, narratorAnimator, sophiaAnimator, anniahAnimator, cam3Animator, cam2Animator, cam1Animator;

	AudioSource narratorAudio, jacobAudio, sophiaAudio;


	public AudioClip[] jacobAudioClips;

	int currentClip = 0;

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

		jacobAudio = jacob.GetComponent<AudioSource> ();
		if (finishedScene1) {
			currentClip = 8;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = timeScale;
		time = Time.timeSinceLevelLoad;


		if (!finishedScene1) {
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
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
				// Previous animation has to have exit time.
				jacobAnimator.SetBool ("LeaveSophia", true);

			}

			if (time > 22f && time < 22f + Time.deltaTime) {
				camera3.depth = -1;
				cam3Animator.SetBool ("Transition", true);

			}

			if (time >= 30 && time < 30f + Time.deltaTime) {
				
				camera1.transform.SetPositionAndRotation(new Vector3 (-1.204f, 1.797f, -0.364f), Quaternion.Euler(30, 60.62f, 0));
			}

			if (time >= 32 && time < 32 + Time.deltaTime) {
				camera1.depth = -1;
				camera3.depth = -3;
				camera2.depth = -2;
			}

			// I think shes getting worse

			if (time >= 41 && time < 41 + Time.deltaTime) {
				camera3.depth = -1;
				camera1.depth = -2;
				camera2.depth = -3;
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// Been thinking
			if (time >= 50 && time < 50 + Time.deltaTime) {
				sophiaAnimator.SetBool ("GetOffCouch", true);

				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			if (time >= 60 && time < 60 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// yes
			if (time >= 70 && time < 70 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// look,
			if (time >= 80 && time < 80 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// if i leave you won't be able to live without me
			if (time >= 90 && time < 90 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// Fine
			if (time >= 100 && time < 100 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			//			if (time >= 90 && time < 90 + Time.deltaTime) {
			//				jacobAudio.clip = jacobAudioClips [currentClip];
			//				jacobAudio.Play ();
			//				currentClip++;
			//			}

			//			if (time >= 95 && time < 95 + Time.deltaTime) {
			//				jacobAudio.clip = jacobAudioClips [currentClip];
			//				jacobAudio.Play ();
			//				currentClip++;
			//			}



			// He leaves Sophia at 100 seconds.

			if (time >= 96 && time < 96 + Time.deltaTime) {
				sophiaAnimator.SetTrigger ("ShakeHead");
			}



			if (time >= 100 && time < 100 + Time.deltaTime) {
				SceneManager.LoadScene ("Scene02");
				finishedScene1 = true;
			}

			//		 Jacob says Anniah is gettings worse and gives spoonful of medicine to Anniah

			//		 Sophia agrees

			//		 Jacob says he wants a boy

			//		 Sophia responds shocked and angry

			//		 They keep talking 



			//		 Jacob gets his stuff and leaves the house.



			// 		 Go to Scene Two
		}
		if (finishedScene1) {

			//Last scene: Scene 03!

			anniah.SetActive (true);



			if (time > 10 && time < 10 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			//Emma hugs Jacob. Asks a question. Is asked to leave.

			// Jacob and Sophia sit down and talk. Very Simple.
		}
	}


}
