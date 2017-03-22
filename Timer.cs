using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	
	float timeLeft = 60.0f;

	public Text text;




	void Update()

	{
		timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + Mathf.Round (timeLeft);
			
		if (timeLeft < 50 && timeLeft > 40) {
			Meteorites.meteorSpeed = -9f;
			SpawnObjects.spawnTime = 3f;
		} else if (timeLeft < 40 && timeLeft > 30) {
			Meteorites.meteorSpeed = -12f;
			SpawnObjects.spawnTime = 2f;
		} else if (timeLeft < 30 && timeLeft > 20) {
			Meteorites.meteorSpeed = -16f;
			SpawnObjects.spawnTime = 1f;
			SpawnObjects.speedSpawner = 2f;
		} else if (timeLeft < 20 && timeLeft > 10) {
			Meteorites.meteorSpeed = -20f;	
			SpawnObjects.spawnTime = 0.8f;
		} else if (timeLeft < 10) {
			Meteorites.meteorSpeed = -30f;	
			SpawnObjects.spawnTime = 0.5f;
		} else if (timeLeft < 0) {
			playerMove.gameOver = true;
			Time.timeScale = 0;
		}
	}

}