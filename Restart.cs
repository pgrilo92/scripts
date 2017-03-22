using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	public Button RestartButton;
	// Use this for initialization
	void Start () {
		Button btn = RestartButton.GetComponent<Button> ();
		btn.onClick.AddListener (taskOnClick);
	}

	void taskOnClick() {
		SceneManager.LoadScene ("debotie scene1");
		Time.timeScale = 1;
		playerMove.grounded = true;
		playerMove.gameOver = false;
	
	}
	}