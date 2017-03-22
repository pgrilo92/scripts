using UnityEngine;
using System.Collections;

public class Meteorites : MonoBehaviour {

		//public HealthBar Health;
		public static float meteorSpeed = -7f;
		// Use this for initialization
		void Update () {
			GetComponent<Rigidbody2D>().velocity = new Vector2(meteorSpeed, 2.8f);

			//Health = FindObjectOfType<HealthBar> ();
		}

		void OnTriggerEnter2D (Collider2D other)
		{
			if (other.gameObject.CompareTag ("Player")) {
			playerMove.gameOver = true;
				Destroy (gameObject);

				//Health.health = Health.health - 10;

		} else if (other.gameObject.CompareTag ("Boundary")) {
				Destroy (gameObject);
			}

	}
}