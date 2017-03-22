using UnityEngine;
using System.Collections;

public class movingBackground : MonoBehaviour {
	public float bgSpeed =0;

	
	// Update is called once per frame
	void Update () { 
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.time*bgSpeed), 0f);
	}
}
