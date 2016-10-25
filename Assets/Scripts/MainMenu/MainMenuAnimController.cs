using UnityEngine;
using System.Collections;

public class MainMenuAnimController : MonoBehaviour {

	public GameObject MainContainer;
	public GameObject ContainerObject;
	public GameObject CircleGO;
	public GameObject AmenitiesGO;
	public GameObject FloorPlanGO;
	public GameObject MapsGO;
	public GameObject FeaturesGO;
	public GameObject LifeStyleGO;
	public GameObject GallaryGO;

	public GameObject GallarySript;

	bool FirstTimeClicked = true;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine ("AnimController");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	IEnumerator AnimController()
	{
		CircleGO.SetActive (true);
		yield return new WaitForSeconds (0.9f);
		AmenitiesGO.SetActive (true);
		yield return new WaitForSeconds (0.4f);
		FloorPlanGO.SetActive (true);
		yield return new WaitForSeconds (0.4f);
		MapsGO.SetActive (true);
		yield return new WaitForSeconds (0.4f);
		FeaturesGO.SetActive (true);
		yield return new WaitForSeconds (0.4f);
		LifeStyleGO.SetActive (true);
		yield return new WaitForSeconds (0.4f);
		GallaryGO.SetActive (true);
		yield return new WaitForSeconds (0.4f);
		ContainerObject.GetComponent<Animation> ().Play ();
	}

	public void MoveCircle()
	{
		if (FirstTimeClicked == true) 
		{
			MainContainer.GetComponent<Animation> ().Play ("MainContainer");
			FirstTimeClicked = false;
		}
	}

	public void GallaryClicked()
	{
		GallarySript.GetComponent<GallaryMainMenu> ().increaseGallaryAplhaVAlue ();
	}

	public void CloseClicked()
	{
		GallarySript.GetComponent<GallaryMainMenu> ().CloseGallary ();
		MainContainer.GetComponent<Animation> ().Play ("CirceReverse");
		FirstTimeClicked = true;
	}
}
