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

	AudioSource narratorAudio, jacobAudio, sophiaAudio, markAudio;

	public AudioClip[] jacobAudioClips, markAudioClips, sophiaAudioClips, narratorAudioClips;

	bool askMedicine;
	bool grabMedicine;
	bool goToAnniah;

	Vector3 offset;

	public int currentClip = 0;
	public int currentClipMark = 0;
	public int currentClipNarrator = 0;
	public int currentClipSophia = 0;

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
		markAudio = mark.GetComponent<AudioSource> ();
		sophiaAudio = sophia.GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {
		Time.timeScale = timeScale;
		time = Time.timeSinceLevelLoad;

		/* Scene Two */ 

		//		 Narrator starts talking

		if (time > 2.0f && time < 2.0f + Time.deltaTime) {
			narratorAudio.Play ();
			jacobAnimator.SetTrigger ("WalkToMark");

		}

		if (time > 2.0f && time < 10.0f + Time.deltaTime) {
			camera1.transform.position = Vector3.Lerp (camera1.transform.position, jacob.transform.position + offset, 1 * Time.deltaTime);

		}

		if (time > 10 && time < 10 + Time.deltaTime) {
			cam1Animator.SetTrigger ("TurnCamera");
		}
			

		// View Narrator
		if (time > 14 && time < 14 + Time.deltaTime) {
			camera2.depth = -1;
			camera1.depth = -2;
		}




		// Jacob says hi to mark.

		if (time >= 16 && time < 16 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Mark says hi. just looking for a better home.
		if (time >= 20 && time < 20 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// He keeps walking when mark responds.

		if (time > 26.0f && time < 29 + Time.deltaTime) {
			camera2.transform.position = Vector3.Lerp (camera2.transform.position, new Vector3 (8, 2, -29), 1 * Time.deltaTime);
		}

		// thats nice
		if (time >= 27 && time < 27 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// What's up you look sad
		if (time >=  32 && time < 32 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// not sad
		if (time >= 36 && time < 36 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Just gonna walk away from me?
		if (time >= 40 && time < 40 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

//		// Come on man you can talk to me.
//		if (time >=  42 && time < 42 + Time.deltaTime) {
//			markAudio.clip = markAudioClips [currentClipMark];
//			markAudio.Play ();
//			currentClipMark++;
//		}

		// Jacob turns around 
		if (time > 45.0f && time <  50 + Time.deltaTime) {
//			Quaternion rotation = jacob.transform.rotation;
//			jacob.transform.rotation = Quaternion.Lerp (jacob.transform.rotation, Quaternion.Euler (0, 0, 0), 360 * Time.deltaTime);
			Vector3 something = jacob.transform.position;
			jacobAnimator.SetTrigger("TurnAround");
			jacob.transform.position = something;
		}

		// fine
		if (time > 45 && time < 45 + Time.deltaTime){
			
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Paces for a little bit.

		if (time > 47 && time <  47 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("StartConvo");
		}

		// where do i start
		if (time > 48 && time < 48 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// You have a wife?
		if (time >=  55 && time < 55 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// Id say had a wife.
		if (time > 57 && time < 57 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Why did you leave her?
		if (time >= 60 && time < 60 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// Long story short
		if (time > 64 && time < 64 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

//		// Interrupts. You have a daughter?
//		if (time >= 72 && time < 72 + Time.deltaTime) {
//			markAudio.clip = markAudioClips [currentClipMark];
//			markAudio.Play ();
//			currentClipMark++;
//		}

		//Actually two daughters.
		if (time > 72 && time < 72 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// So you said women aren't strong at all? to a woman?
		if (time >=  95 && time < 95 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// exactly
		if (time > 100 && time < 100 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Have you ever thought abnout what's going on in her mind?
		if (time >=  105 && time < 105 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// theres no need to
		if (time > 110 && time < 110 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// First of all.
		if (time >=  116 && time < 116 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// me and my friends (to himself)
		if (time > 135 && time < 135 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// dont think its right(out loud)
		if (time > 147 && time < 147 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Then apologize to her.
		if (time >= 161 && time < 161 + Time.deltaTime) {
			markAudio.clip = markAudioClips [currentClipMark];
			markAudio.Play ();
			currentClipMark++;
		}

		// yeah I should 
		if (time > 165 && time < 165 + Time.deltaTime){

			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}


		// Jacob walks toward his house.

		if (time > 169 && time <  169 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("WalkToHouse");

		}

//		// Man I'm good at these talks.
//		if (time >=  180 && time < 180 + Time.deltaTime) {
//			markAudio.clip = markAudioClips [currentClipMark];
//			markAudio.Play ();
//			currentClipMark++;
//		}
		 
		// narrator says it took a lot of courage while jacob walks.

		if (time >=  172 && time < 172 + Time.deltaTime) {
			narratorAudio.clip = narratorAudioClips [currentClipNarrator];
			narratorAudio.Play ();
			currentClipNarrator++;
		}

		// Switch to camera 1. Set offset
		if (time > 180 && time < 180 + Time.deltaTime) {
			//cam1Animator.SetTrigger ("FollowJacob");
			camera1.depth = -1;
			camera2.depth = -2;
			Vector3 offset = new Vector3 (-3, 2, 0);
			camera1.transform.position = jacob.transform.position + offset;
		}

		// Follow jacob walking home. With new offset.
		if (time > 179 && time < 190 + Time.deltaTime) {
			if (time > 182 && time < 182 + Time.deltaTime) {
				offset = camera1.transform.position - jacob.transform.position;
			}
			camera1.transform.position = jacob.transform.position + offset;
		}

		// hi sophia
		if (time > 189 && time < 189 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// go away
		if (time > 194 && time < 194 + Time.deltaTime) {
			sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
			sophiaAudio.Play ();
			currentClipSophia++;

		}

		// sorry Sophia
		if (time > 198 && time < 198 + Time.deltaTime) {
			jacobAudio.clip = jacobAudioClips [currentClip];
			jacobAudio.Play ();
			currentClip++;
		}

		// Narrator says started leaving after 5 minutes.
		if (time >=  208 && time < 208 + Time.deltaTime) {
			narratorAudio.clip = narratorAudioClips [currentClipNarrator];
			narratorAudio.Play ();
			currentClipNarrator++;
		}

		// Start leaving
		if (time > 210 && time <  210 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("StartLeaving");
		}

		// Switch camera to not see the door.
		if (time > 217 && time < 217 + Time.deltaTime) {
			camera1.transform.position = new Vector3 (10.287f, 1.852f, 2.228f);
		}

		// I havent forgiven you yet. But lets talk.
		if (time > 219 && time < 219) {
			sophiaAnimator.SetTrigger ("WelcomeJacobBack");
			sophiaAudio.clip = sophiaAudioClips [currentClipSophia];
			sophiaAudio.Play ();
			currentClipSophia++;
		}

		// sophia lets him in when he starts leaving.

		// rotate camera to see door
		if (time > 225 && time < 225 + Time.deltaTime) {
			camera1.transform.rotation = Quaternion.Euler(20, 0, 0);
		}

		// scene three( go to scene one)


//		if (time > 230 && time < 230 + Time.deltaTime) {
//			fadeAnimator.SetTrigger ("FadeIn");
//		}
		if (time >= 231 && time < 231 + Time.deltaTime) {
			GameControllerSceneOne.finishedScene1 = true;
			SceneManager.LoadScene ("Scene01");

		}
	}

}
