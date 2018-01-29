using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerSceneTwo : MonoBehaviour {


	public float timeScale = 1;

	public static bool finishedScene1;

	GameObject jacob, sophia, mark, narrator;

	Camera camera1, camera2, camera3;

	public float time;

	Animation jacobWalk, jacobIdle, sophiaIdle, markIdle;

	public Animator jacobAnimator, narratorAnimator, sophiaAnimator, anniahAnimator, cam3Animator, cam2Animator, cam1Animator, fadeAnimator;

	AudioSource narratorAudio, jacobAudio, sophiaAudio;

	public AudioClip[] jacobAudioClips;

	bool askMedicine;
	bool grabMedicine;
	bool goToAnniah;

	Vector3 offset;

	int currentClip = 0;

	// Use this for initialization
	void Start () {
		time = 0;
		// Characters
		jacob = GameObject.Find ("Jacob");
		sophia = GameObject.Find ("Sophia");
		mark = GameObject.Find ("Mark");	
		narrator = GameObject.Find ("Narrator");

		// Audio
		narratorAudio = narrator.GetComponent<AudioSource>();

		// Camera
		camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
		camera2 = GameObject.Find ("Camera2").GetComponent<Camera>();
		//camera3 = GameObject.Find ("Camera3").GetComponent<Camera>();

		offset = camera1.transform.position - jacob.transform.position;

		jacobAudio = jacob.GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {
		Time.timeScale = timeScale;
		time = Time.timeSinceLevelLoad;

		/* Scene Two */ 

		//		 Narrator starts talking

		if (time > 2.0f && time <  2.0f + Time.deltaTime) {
			narratorAudio.Play ();
			jacobAnimator.SetTrigger ("WalkToMark");

		}

		if (time > 2.0f && time <  10.0f + Time.deltaTime) {
			camera1.transform.position = Vector3.Lerp (camera1.transform.position, jacob.transform.position + offset, 1 * Time.deltaTime);

		}

		if (time > 10 && time <  10 + Time.deltaTime) {
			cam1Animator.SetTrigger ("TurnCamera");
		}
			

		// View Narrator
		if (time > 14 && time < 14 + Time.deltaTime) {
			camera2.depth = -1;
			camera1.depth = -2;
		}




		// Jacob says hi to mark.

		if (time >= 18 && time < 18 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// He keeps awlking when mark responds.

		if (time > 20.0f && time <  26 + Time.deltaTime) {
			camera2.transform.position = Vector3.Lerp (camera2.transform.position, new Vector3(8, 2, -29), 1 * Time.deltaTime);
		}

		if (time >= 22 && time < 22 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}


		if (time >= 26 && time < 26 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Jacob turns around says fine. Convo starts.
		if (time > 29.0f && time <  35 + Time.deltaTime) {
//			Quaternion rotation = jacob.transform.rotation;
//			jacob.transform.rotation = Quaternion.Lerp (jacob.transform.rotation, Quaternion.Euler (0, 0, 0), 360 * Time.deltaTime);
			Vector3 something = jacob.transform.position;
			jacobAnimator.SetTrigger("TurnAround");
			jacob.transform.position = something;



		}

		if (time > 29 && time < 29 + Time.deltaTime){
			
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Paces for a little bit.

		if (time > 32 && time <  32 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("StartConvo");
		}



		// Long talk

		if (time > 35 && time < 35 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		if (time > 45 && time < 45 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Long story short
		if (time > 55 && time < 55 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		if (time > 65 && time < 65 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// exactly
		if (time > 95 && time < 95 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// theres no need to
		if (time > 110 && time < 110 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// me and my friends
		if (time > 120 && time < 120 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// dont think its right
		if (time > 130 && time < 130 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// yeah I should 
		if (time > 140 && time < 140 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}
		 
		// narrator says it took a lot of courage while jacob walks.

		//  sophia says go away.

		// narrator talks 



		// Jacob walks toward his house.

		if (time > 143 && time <  143 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("WalkToHouse");

		}

		if (time > 147 && time < 147 + Time.deltaTime) {
			//cam1Animator.SetTrigger ("FollowJacob");
			camera1.depth = -1;
			camera2.depth = -2;
			Vector3 offset = new Vector3 (-3, 2, 0);
			camera1.transform.position = jacob.transform.position + offset;
		}

		// follow jacob walking home
		if (time > 147 && time < 158 + Time.deltaTime) {
			if (time > 147 && time < 147 + Time.deltaTime) {
				offset = camera1.transform.position - jacob.transform.position;
			}
			camera1.transform.position = jacob.transform.position + offset;
		}

		// hi sophia
		if (time > 159 && time < 159 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// sorry
		if (time > 165 && time < 165 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		if (time > 180 && time <  180 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("StartLeaving");

		}

		if (time > 185 && time < 185 + Time.deltaTime) {
			camera1.transform.position = new Vector3 (10.287f, 1.852f, 2.228f);
		}

		if (time > 190 && time < 190) {
			sophiaAnimator.SetTrigger ("WelcomeJacobBack");
		}
		// sophia lets him in when he starts leaving.



		// rotate camera to see door
		if (time > 200 && time < 200 + Time.deltaTime) {
			camera1.transform.rotation = Quaternion.Euler(20, 0, 0);
		}

		// scene three( go to scene one)


		if (time > 203 && time < 203 + Time.deltaTime) {
			fadeAnimator.SetTrigger ("FadeIn");
		}
		if (time >= 205 && time < 205 + Time.deltaTime) {
			GameControllerSceneOne.finishedScene1 = true;
			SceneManager.LoadScene ("Scene01");

		}
	}

}
