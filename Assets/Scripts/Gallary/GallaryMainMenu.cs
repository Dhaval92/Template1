using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GallaryMainMenu : MonoBehaviour {

	public GameObject GallaryGO;

	public GameObject[] ImageGO;
	public Text[] TextGO;

	public Text InteriorTxt;
	public Text ExteriorTxt;
	public Text PanoramicTxt;

	public bool showGallaryFlag = false;
	public bool showIneriorFlag = false;

	#region
	//Gallary
	public Text InteriorTxt_2;
	public Image interiorImages;
	#endregion

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (showGallaryFlag == true)
		{
			Color temp = ImageGO[0].GetComponent<Image> ().color;
			temp.a += 0.01f;
			ImageGO[0].GetComponent<Image> ().color = temp;
			ImageGO[1].GetComponent<Image> ().color = temp;
			ImageGO[2].GetComponent<Image> ().color = temp;
			ImageGO[3].GetComponent<Image> ().color = temp;
			ImageGO[4].GetComponent<Image> ().color = temp;
			TextGO[0].color = temp;
			TextGO[1].color = temp;
			TextGO[2].color = temp;
		}

		else if (showIneriorFlag == true) 
		{
			Color tempDecrease = ImageGO[0].GetComponent<Image> ().color;
			tempDecrease.a -= 0.1f;
			Debug.Log (tempDecrease.a);
			if (tempDecrease.a >= -0.1f) 
			{
				ImageGO [0].GetComponent<Image> ().color = tempDecrease;
				ImageGO [1].GetComponent<Image> ().color = tempDecrease;
				ImageGO [2].GetComponent<Image> ().color = tempDecrease;
				TextGO [0].color = tempDecrease;
				TextGO [1].color = tempDecrease;
				TextGO [2].color = tempDecrease;
			}

			Color tempIncrease = interiorImages.color;
			tempIncrease.a += 0.01f;
			InteriorTxt_2.color = tempIncrease;
			interiorImages.color = tempIncrease;
		}
	}

	public void ResetAllVAlue()
	{
		for (int i = 0; i >= ImageGO.Length; i++)
		{
			Color initialColor = ImageGO [i].GetComponent<Image> ().color;
			initialColor.a = 0.0f;
			ImageGO [i].GetComponent<Image> ().color = initialColor;
		}

		for (int p = 0; p >= TextGO.Length; p++)
		{
			Color initialColor = TextGO [p].color;
			initialColor.a = 0.0f;
			TextGO [p].color = initialColor;
		}

		Color setZero = interiorImages.color;
		setZero.a = 0.0f;
		InteriorTxt_2.color = setZero;
		interiorImages.color = setZero;
	}

	public void increaseGallaryAplhaVAlue()
	{
		setAllFalgsToFalse ();
		GallaryGO.SetActive (true);
		showGallaryFlag = true;
	}

	public void ineriorClicked()
	{
		setAllFalgsToFalse ();
		showIneriorFlag = true;
	}

	public void setAllFalgsToFalse()
	{
		showGallaryFlag = false;
		showIneriorFlag = false;
	}

	public void CloseGallary()
	{
		setAllFalgsToFalse ();
		ResetAllVAlue ();
		GallaryGO.SetActive (false);
	}
}
