using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour {
	public Button PauseButton;
	// Use this for initialization
	void Start () {
		Button btn = PauseButton.GetComponent<Button> ();
		btn.onClick.AddListener (taskOnClick);
	}

	void taskOnClick() {
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
		
		
		}
		else
		{
			Time.timeScale = 1;
		}
	}
	/*
	public void TogglePanel (GameObject panel)
	{
		panel.SetActive (!panel.activeSelf);
	}
	void OnGUI()
	{
		if (GUI.Button (newRect(-440, 350, 0, 0), btnTexture))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
			}
			else
			{
				Time.timeScale = 1;
			}
		}
	}*/
}
