using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {
	public Button goToGameScene;
	// Use this for initialization
	void Start () {
		Button btn = goToGameScene.GetComponent<Button> ();
		btn.onClick.AddListener (taskOnClick);
	}

	void taskOnClick() {
		SceneManager.LoadScene ("debotie scene1");
		//Time.timeScale = 1;
		playerMove.grounded = true;
		playerMove.gameOver = false;

	}
}
