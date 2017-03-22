using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class goMainMenu : MonoBehaviour {

	public Button goMainMenuButton;
	// Use this for initialization
	void Start () {
		Button btn = goMainMenuButton.GetComponent<Button> ();
		btn.onClick.AddListener (taskOnClick);
	}

	void taskOnClick() {
		SceneManager.LoadScene ("MainMenu");
		//Time.timeScale = 1;
		playerMove.grounded = true;
		playerMove.gameOver = false;

	}
}
