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




		// Jacob says hi to mark.

		// He keeps awlking when mark responds.

		if (time > 20.0f && time <  26 + Time.deltaTime) {
			camera2.transform.position = Vector3.Lerp (camera2.transform.position, new Vector3(8, 2, -29), 1 * Time.deltaTime);
		}

		// Jacob turns around says fine. Convo starts.
		if (time > 29.0f && time <  35 + Time.deltaTime) {
//			Quaternion rotation = jacob.transform.rotation;
//			jacob.transform.rotation = Quaternion.Lerp (jacob.transform.rotation, Quaternion.Euler (0, 0, 0), 360 * Time.deltaTime);
			Vector3 something = jacob.transform.position;
			jacobAnimator.SetTrigger("TurnAround");
			jacob.transform.position = something;
		}

		// Paces for a little bit.

		if (time > 34 && time <  34 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("StartConvo");
		}

		// Long talk

		// Jacob walks toward his house.

		if (time > 50&& time <  50 + Time.deltaTime) {
			jacobAnimator.SetTrigger ("WalkToHouse");
		}
		 
		// narrator says it took a lot of courage while jacob walks.

		//  sophia opens door sees its jacob slams it back.

		// narrator talks 

		// sophia lets him in when he leaves.

		// scene three( go to scene one)



		if (time >= 103 && time < 103 + Time.deltaTime) {
			SceneManager.LoadScene ("Scene01");
			finishedScene1 = true;
		}
	}

}
