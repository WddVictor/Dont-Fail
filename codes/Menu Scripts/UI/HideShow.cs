using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShow : MonoBehaviour {
	public GameObject[] shouldHide;
	public GameObject[] shouldShow;

	public void hideAll(){
		foreach (GameObject item in shouldHide)
		{
			item.GetComponent<hide>().Hide();
		}
	}
	public void showAll(){
		foreach (GameObject item in shouldHide)
		{
			item.GetComponent<hide>().Show();
		}
	}

}
