using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetImages : MonoBehaviour {

	WWW path;
	public string[] textureImage2;

	Texture2D tempImage;

	public GameObject[] menuGO;

	string fixedPath = "D:\\Projects\\Unity Projects\\MiHome\\testImages\\";

	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i <= 5; i++) 
		{
			path = new WWW ("file://" + fixedPath + textureImage2 [i]);
			Debug.Log ("file://" + fixedPath + textureImage2 [i]);
			tempImage = path.texture;
			menuGO[i].GetComponent<Image> ().material.mainTexture = tempImage;
			Debug.Log ("Texture Applied");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
