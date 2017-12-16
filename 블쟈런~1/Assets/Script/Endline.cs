using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endline : MonoBehaviour {
	public GameObject EndMenu;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Time.timeScale = 0f;
			EndMenu.SetActive (true);
		}
	}
}
