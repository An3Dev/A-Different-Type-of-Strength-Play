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
		camera3 = GameObject.Find ("Camera3").GetComponent<Camera>();

	}

	// Update is called once per frame
	void Update () {
		Time.timeScale = timeScale;
		time = Time.time;

		/* Scene Two */ 

		//		 Narrator starts talking

		if (time > 2.0f && time <  2.0f + Time.deltaTime) {
			narratorAudio.Play ();
		}

		//		 Camera switches to views of Anniah, Jacob, and Sophia 

		// View Narrator
		if (time > 8.0f && time < 8.0f + Time.deltaTime) {
			camera2.depth = -1;
			camera1.depth = -2;
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

		if (time >= 30 && time < 30f + Time.deltaTime) {
			camera1.transform.SetPositionAndRotation(new Vector3 (-1.204f, 1.797f, -0.364f), Quaternion.Euler(30, 60.62f, 0));
		}

		if (time >= 35 && time < 35 + Time.deltaTime) {
			camera1.depth = -1;
			camera3.depth = -3;
			camera2.depth = -2;
		}


		if (time >= 41 && time < 41 + Time.deltaTime) {
			camera3.depth = -1;
			camera1.depth = -2;
			camera2.depth = -3;
		}

		if (time >= 46 && time < 46 + Time.deltaTime) {
			sophiaAnimator.SetBool ("GetOffCouch", true);
		}

		// He leaves Sophia at 100 seconds.

		if (time >= 100 && time < 100 + Time.deltaTime) {
			sophiaAnimator.SetTrigger ("ShakeHead");
		}

		if (time >= 103 && time < 103 + Time.deltaTime) {
			SceneManager.LoadScene ("Scene02");
			finishedScene1 = true;
		}
	}

}
