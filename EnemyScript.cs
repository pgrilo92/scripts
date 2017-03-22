using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private Rigidbody2D myEnemy;
		//public HealthBar Health;
		//public float EnemyXSpeed = 0f;
	//public float EnemyYSpeed = 0f;
		// Use this for initialization
	public bool directionLeft = true;
	public float moveTime = 1f;
	public AudioClip enemyJumpSound;

	private AudioSource sourceE;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;


	void Awake () {

		sourceE = GetComponent<AudioSource>();

	}

		void Start () {
		myEnemy = GetComponent<Rigidbody2D> ();
		//GetComponent<Rigidbody2D>().velocity = new Vector2(EnemyXSpeed, EnemyYSpeed);
		InvokeRepeating("EnemyMove", 0, moveTime);
		}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
			playerMove.gameOver = true;

		

		} else if (other.name == "ChangeDirectionElChipo (1)") {
			//GetComponent<Rigidbody2D>().velocity = new Vector2(EnemyXSpeed, EnemyYSpeed);
			directionLeft = true;

		}else if (other.name == "ChangeDirectionElChipo") {
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-EnemyXSpeed, -EnemyYSpeed);
			directionLeft = false;

		}
		}

	void EnemyMove(){

		if (directionLeft == true) {
			Vector3 distance = new Vector3 (-1.0f, 0.225f, 0.0f);
			myEnemy.transform.Translate (distance);
			sourceE.PlayOneShot(enemyJumpSound,volLowRange);
		} else if (directionLeft == false) {
			Vector3 distance = new Vector3 (1.0f, -0.225f, 0.0f);
			myEnemy.transform.Translate (distance);
			sourceE.PlayOneShot(enemyJumpSound,volHighRange);

		
		}
	}


	}