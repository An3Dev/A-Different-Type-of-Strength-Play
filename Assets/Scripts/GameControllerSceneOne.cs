using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerSceneOne : MonoBehaviour {

	public float timeScale = 1;

	public static bool finishedScene1;
	public bool finishedScenePublic;

	GameObject jacob, sophia, anniah, narrator, emma, medicineBottle;

	Camera camera1, camera2, camera3;

	public float time;

	Animation jacobWalk, jacobIdle, sophiaIdle, anniahIdle;

	public Animator jacobAnimator, narratorAnimator, sophiaAnimator, anniahAnimator, cam3Animator, cam2Animator, cam1Animator, emmaAnimator, fadeAnimator;

	AudioSource narratorAudio, jacobAudio, sophiaAudio, emmaAudio;

	Vector3 medicineOffset;


	public AudioClip[] jacobAudioClips, sophiaAudioClips, narratorAudioClips, emmaAudioClips;

	int currentClip = 0;
	int currentClipSophia = 0;
	int currentClipEmma = 0;

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
		emma = GameObject.Find ("Emma");
		medicineBottle = GameObject.Find ("MedicineBottle");

		// Audio
		narratorAudio = narrator.GetComponent<AudioSource>();

		// Camera
		camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
		camera2 = GameObject.Find ("Camera2").GetComponent<Camera>();
		camera3 = GameObject.Find ("Camera3").GetComponent<Camera>();

		jacobAudio = jacob.GetComponent<AudioSource> ();

		if (finishedScene1) {
			currentClip = 8;
			currentClipSophia = 6;
			emma.SetActive (true);
		} else {
			emma.SetActive (false);
		}

		finishedScenePublic = finishedScene1;
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

//			if (time > 29 && time < 36 + Time.deltaTime) {
//			}

			if (time > 22f && time < 22f + Time.deltaTime) {
				camera3.depth = -1;
				cam3Animator.SetBool ("Transition", true);

			}

			if (time >= 30 && time < 30f + Time.deltaTime) {
				
				camera1.transform.SetPositionAndRotation(new Vector3 (-1.204f, 1.797f, -0.364f), Quaternion.Euler(30, 60.62f, 0));
			}

			if (time >= 33 && time < 33 + Time.deltaTime) {
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

			// Yeah (Sophia)

			if (time >= 46 && time < 46 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}

			// Been thinking
			if (time >= 50 && time < 50 + Time.deltaTime) {
				sophiaAnimator.SetBool ("GetOffCouch", true);

				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// What?

			if (time >= 54 && time < 54 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}


			// Only 75 percent

			if (time >= 60 && time < 60 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// Only?

			if (time >= 46 && time < 46 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}



			// yes
			if (time >= 70 && time < 70 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// Theres a 50 percent chance of having a boy

			if (time >= 46 && time < 46 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}

			// look,
			if (time >= 80 && time < 80 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}



			// Physical strength is all that matters to you?

			if (time >= 46 && time < 46 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}

			// if i leave you won't be able to live without me
			if (time >= 90 && time < 90 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// Then leave!

			if (time >= 46 && time < 46 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}

			// Fine
			if (time >= 100 && time < 100 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// He leaves Sophia at 100 seconds.

			if (time >= 96 && time < 96 + Time.deltaTime) {
				sophiaAnimator.SetTrigger ("ShakeHead");
			}


			if (time >= 96 && time < 96 + Time.deltaTime) {
				fadeAnimator.SetTrigger ("FadeOut");
			}
			if (time >= 100 && time < 100 + Time.deltaTime) {
				finishedScene1 = true;
				SceneManager.LoadScene ("Scene02");

			}

			//		 Jacob says Anniah is gettings worse and gives spoonful of medicine to Anniah

			//		 Sophia agrees

			//		 Jacob says he wants a boy

			//		 Sophia responds shocked and angry

			//		 They keep talking 



			//		 Jacob gets his stuff and leaves the house.



			// 		 Go to Scene Two
		}


/*/////////////////////Scene 3//////////////////////*/
		if (finishedScene1) {
			//Last scene: Scene 03!
			if (time > 0.1f && time < 0.1f + Time.deltaTime) {
				camera2.depth = -3;
				camera1.depth = -2;
				camera3.depth = -1;
				cam3Animator.SetTrigger ("Transition");
			}

			if (time > 5 && time < 5 + Time.deltaTime) {
				sophiaAnimator.SetTrigger ("FaceJacob");
			}

			// Where were you?

			if (time >= 46 && time < 46 + Time.deltaTime) {
				emmaAudio.clip = emmaAudioClips [currentClipEmma];
				emmaAudio.Play ();
				currentClipEmma++;
			}

			// tel you why later
			if (time > 10 && time < 10 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// OK.

			if (time >= 16 && time < 16 + Time.deltaTime) {
				emmaAudio.clip = emmaAudioClips [currentClipEmma];
				emmaAudio.Play ();
				currentClipEmma++;
			}

			if (time > 17 && time < 17 + Time.deltaTime) {
				emmaAnimator.SetTrigger ("LeaveRoom");
				jacobAnimator.SetTrigger ("FaceSophia");

			}


			// i was wrong
			if (time > 22 && time < 22 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
				currentClip++;
			}

			// what made you change?

			if (time >= 36 && time < 36 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}

			// an old friend
			if (time > 40 && time < 40 + Time.deltaTime) {
				jacobAudio.clip = jacobAudioClips [currentClip];
				jacobAudio.Play ();
			}

			// Yes. I forgive you.

			if (time >= 60 && time < 60 + Time.deltaTime) {
				sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
				sophiaAudio.Play ();
				currentClipSophia++;
			}
		}
	}


}
