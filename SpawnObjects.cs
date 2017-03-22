using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {

	// Variable to store the meteorite prefab
	public GameObject meteorite;
	// Variable to know how fast we should create new enemies
	public static float spawnTime = 5f;
	private bool dirUp = true;
	public static float speedSpawner = 1.0f;



	IEnumerator addMeteorite() {

		while (true) {
			var spawnPoint = new Vector2 (transform.position.x, transform.position.y);

			// Create an meteorite at the 'spawnPoint' position
			Instantiate (meteorite, spawnPoint, Quaternion.identity);
		
			yield return new WaitForSeconds (spawnTime);
		}
	}

	void Start() {
		// Call the 'addmeteorite' function in 0 second
		// Then every 'spawnTime' seconds
		//InvokeRepeating("addMeteorite", 0, spawnTime);
		{
			StartCoroutine(addMeteorite());
		}
	}

	void Update() {

		if (dirUp)
			transform.Translate(Vector2.up * speedSpawner * Time.deltaTime);
		else 
			transform.Translate(-Vector2.up * speedSpawner * Time.deltaTime);

		if(transform.position.y >= 4.0f) {
			dirUp = false;
		}

		if(transform.position.y <= -4) {
			dirUp = true;
		}
			
	}



	// New function to spawn an meteorite
	/*void addMeteorite() {
		// Get the renderer component of the spawn object
		//var rd = GetComponent("Renderer");

		var spawnPoint = new Vector2(transform.position.x, transform.position.y);

		// Create an meteorite at the 'spawnPoint' position
		Instantiate(meteorite, spawnPoint, Quaternion.identity);
	} */
}