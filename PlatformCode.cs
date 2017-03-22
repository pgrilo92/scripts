using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlatformCode : MonoBehaviour {
	//BlackHoleMaker change;
	Animator anim;
	Score addScore;
	private bool playerDead;
	private bool isBlack = false;
	//private bool changeToBlackM;
	//public GameObject platform;
	private string platformString;
	//private bool isPLayerOn;
	//private Rigidbody2D myCurrentPlatform;
	//public Text scoreTextPop;

	private bool playOnPlatform=false;

	IEnumerator threeSecondCounter()
	{
		while (true) {
			

			platformString = Random.Range(0,90).ToString();
			yield return new WaitForSeconds (3);

		}
	}

	// Use this for initialization
	void Start () {
		{
			StartCoroutine(threeSecondCounter());
		}
		anim = GetComponent<Animator>();
		addScore = FindObjectOfType<Score> ();

	


	}

void Update () {

		playerDead = playerMove.gameOver;
		playOnPlatform = anim.GetBool ("activeColor");
		//changeToBlackM = BlackHoleMaker.blackM;
		//changing variable for animation of blackhole
		if (this.name == platformString ) {
			anim.SetBool ("changeToBlack", true);
			isBlack = true;

		} else {
			anim.SetBool ("changeToBlack", false);
			isBlack = false;
		}

}

	//Setting when a player collides with the platform using the public variable onPlatform
	void OnTriggerEnter2D ( Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			if (!playerDead) {
				anim.SetBool ("onplatform", true);
				if (!isBlack) {
					if (playOnPlatform == false) {
						//variable tells us if the platform color has been changed.
						anim.SetBool ("activeColor", true);
						addScore.score = addScore.score + 50;
					}


					//var spawnPoint = new Vector2(transform.position.x, transform.position.y);

					// Create an meteorite at the 'spawnPoint' position
					//Instantiate(scoreTextPop, spawnPoint, Quaternion.identity);

				} else {
					//if players goes on a black hole he loses half of the points
					addScore.score = addScore.score - (addScore.score / 2);
				}
			}
			//anim.SetBool("ground", isPLayerOn);
		}
	}
	//This will indicate the interactions has stopped
	void OnTriggerExit2D ( Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			anim.SetBool("onplatform", false);
			//anim.SetBool("ground",isPLayerOn);
		}
	}

	// New function to spawn an meteorite
	/*void addScoreText() {
	// ***Need to ADD THIS CODE TO  SEPARATE SCRIPT FILE IN ORDER TO HAVE THE TEXT POP UP LIKE THE TEXT FOR THE TIMER DOES MAKE IT NEED TO ANIMATE THE SCORE MOVING UP AND DISAPPEARING ****
	 
		// Get the renderer component of the spawn object
		//var rd = GetComponent("Renderer");

		var spawnPoint = new Vector2(transform.position.x, transform.position.y);

		// Create an meteorite at the 'spawnPoint' position
		Instantiate(scoreTextPop, spawnPoint, Quaternion.identity);
	} */

}
