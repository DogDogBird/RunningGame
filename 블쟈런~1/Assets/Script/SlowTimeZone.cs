using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTimeZone : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{

			Time.timeScale =0.5f;
		}
	}
}
