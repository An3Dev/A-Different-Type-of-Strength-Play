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

	public Animator jacobAnimator, narratorAnimator, sophiaAnimator, anniahAnimator, cam3Animator, cam2Animator, cam1Animator;

	AudioSource narratorAudio, jacobAudio, sophiaAudio;

	AudioClip gettingWorseJacob, gettingWorseAnniah;

	bool askMedicine;
	bool grabMedicine;
	bool goToAnniah;

	Vector3 offset;

	// Use this for initialization
	void Start () {
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

	}

	// Update is called once per frame
	void Update () {
		Time.timeScale = timeScale;
		time = Time.time;

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

		if (time > 20.0f && time <  28 + Time.deltaTime) {
			offset = camera2.transform.position - jacob.transform.position;
			camera2.transform.position = Vector3.Lerp (camera1.transform.position, jacob.transform.position + offset, 1 * Time.deltaTime);
		}


		// Jacob says hi to mark.

		// He keeps awlking when mark responds.

		// Jacob turns around says fine. Convo starts.

		// Paces for a little bit.

		// Long talk

		// Jacob walks toward his house.
		 
		// narrator says it took a lot of courage while jacob walks.

		//  sophia opens door sees its jacob slams it back.

		// narrator talks 

		// sophia lets him in when he leaves.

		// scene three( go to scene one)



		if (time >= 103 && time < 103 + Time.deltaTime) {
			SceneManager.LoadScene ("Scene02");
			finishedScene1 = true;
		}
	}

}
