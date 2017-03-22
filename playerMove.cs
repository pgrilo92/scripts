using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class playerMove : MonoBehaviour {
	
	Animator anim;
	//declaring variable for player's body
	private Rigidbody2D myGameObject;
	public Transform groundCheck;
	public static bool grounded = true;
	public LayerMask whatIsGround;
	float groundRadius = 0.2f;
	//declring variable in order to use parts of the platform code
	PlatformCode platform;
	public bool playerOnPlatform = false;
	public static bool gameOver = false;
	GameObject yourCanvas;
	GameObject playButton;
	public AudioClip jumpSound;
	public AudioClip gameOverSound;

	private AudioSource source;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;


	void Awake () {

		source = GetComponent<AudioSource>();

	}


	// Use this for initialization
	void Start () {
		
		myGameObject = GetComponent<Rigidbody2D> ();
		yourCanvas = GameObject.Find("CanvasForPanel");
		yourCanvas.GetComponent<Canvas> ();
		playButton = GameObject.Find("Play/Pause");
		Time.timeScale = 1;

	}

	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		//anim.SetBool ("Ground", grounded);
	}
	// Update is called once per frame
	void Update () {

		if (gameOver) {
			GetComponent<Rigidbody2D> ().gravityScale = 5f;
			grounded = false;
			yourCanvas.GetComponent<Canvas> ().enabled = true;
			//Time.timeScale = 0;
		}
		
		
		if (grounded) {
			gameOver = false;

			//how controls from TouchControl affect the movement of the player
			/*	if (TouchControl.IsSwipingLeft ()) {
				//Vector given for each swipe done by user, determining the optimal distance in order to keep player in middle of platform
				Vector3 distance = new Vector3 (-1.0f, -0.225f, 0.0f);
				//Vector3 distance = new Vector3 (-2f, 0f, 0f);
				//calling variable of player body and changing the transform by trasnlating by the distance declared with the specific distance vector
				myGameObject.transform.Translate (distance);
				//float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);

			} else if (TouchControl.IsSwipingRight ()) {
				//Vector3 distance = new Vector3 (2f, 0f, 0f);
				Vector3 distance = new Vector3 (1.0f, 0.225f, 0f);
				//Vector3 distance = new Vector3 (1.9f, 0f, 0f);
				myGameObject.transform.Translate (distance);
				//float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);

			} else if (TouchControl.IsSwipingUp ()) {
				Vector3 distance = new Vector3 (-1.0f, 0.225f, 0.0f);
				//Vector3 distance = new Vector3 (0f, 0.4f, 0f);
				//Vector3 distance = new Vector3 (0f, 0.81f, 0f);
				myGameObject.transform.Translate (distance);
				//float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);

			} else if (TouchControl.IsSwipingDown ()) {
				Vector3 distance = new Vector3 (1.0f, -0.225f, 0.0f);
				//Vector3 distance = new Vector3 (0f, -0.4f, 0f);
				//Vector3 distance = new Vector3 (0f, -0.81f, 0f);
				myGameObject.transform.Translate (distance);
				//float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);

			} else*/

			if (TouchControl.IsSwipingDownRight ()) {
				Vector3 distance = new Vector3 (1.0f, -0.225f, 0.0f);
				myGameObject.transform.Translate (distance);
				//float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);
				
			} else if (TouchControl.IsSwipingUpRight ()) {
				Vector3 distance = new Vector3 (1.0f, 0.225f, 0f);
				myGameObject.transform.Translate (distance);
				//float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);
			
			} else if (TouchControl.IsSwipingDownLeft ()) {
				Vector3 distance = new Vector3 (-1.0f, -0.225f, 0.0f);
				myGameObject.transform.Translate (distance);
				float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);

			} else if (TouchControl.IsSwipingUpLeft ()) {
				Vector3 distance = new Vector3 (-1.0f, 0.225f, 0.0f);
				myGameObject.transform.Translate (distance);
				//float vol = Random.Range (volLowRange, volHighRange);
				source.PlayOneShot (jumpSound, volLowRange);
			} 

		} else {
				//GetComponent<Rigidbody2D> ().gravityScale = 5f;
				gameOver = true;
				//yourCanvas.SetActive(true);
				playButton.SetActive (false);
				source.PlayOneShot (gameOverSound, volLowRange);
			   
				
		
			}

		
		
		}
	}


	/*void OnTriggerStay2D (Collider2D other){
		if (other.gameObject.CompareTag ("Platform")) {
			playerOnPlatform = true;
		} else if (!(other.gameObject.CompareTag ("Platform"))) { 
			playerOnPlatform = false;
		}
	}*/


