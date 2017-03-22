using UnityEngine;
using System.Collections;

public class CustomizeMenu : MonoBehaviour {
	public GameObject levelButtonPrefab;
	public GameObject levelButtonContainer;
	// Use this for initialization
	void Start () {
		/*Sprite[] thumbnails = Resources.LoadAll<Sprite> ("Levels");
			foreach (Sprite thumbnail in thumbnails)
			{
				GameObject container = Instantiate (levelButtonPrefab) as GameObject;
				container.GetComponent<Image> ().sprite = thumbnail;
				container.transform.SetParent(levelButtonContainer.transform, false);
				string CharName = thumbnails.name;
	}*/
	
	// Update is called once per frame
	//void Update () {
	
	}
	public void LookAtMenu( Transform menuTransform) {
		Camera.main.transform.LookAt (menuTransform.position);
	}
}
