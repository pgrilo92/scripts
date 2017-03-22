using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {


		// Variable to store the meteorite prefab
		public GameObject enemy;
		// Variable to know how fast we should create new enemies
		//public float spawnTimeEnemy = 10;
		//private bool dirUp = true;
		//public float speed = 1.0f;
	void addEnemy() {
		// Get the renderer component of the spawn object
		//var rd = GetComponent("Renderer");

		var spawnPointE = new Vector2(this.transform.position.x, this.transform.position.y);

		// Create an meteorite at the 'spawnPoint' position
		Instantiate(enemy, spawnPointE, Quaternion.identity);
	} 

		void Start() {
			// Call the 'addmeteorite' function in 0 second
			// Then every 'spawnTime' seconds
			InvokeRepeating("addEnemy", 10f , 0);
		}


		// New function to spawn an meteorite
		
	}
	

