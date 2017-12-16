using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager_Overwatch : MonoBehaviour {
    public GameObject theArrow;
	public GameObject Hanzo;
	public GameObject Sound;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			Sound.SetActive (true);
			Hanzo.SetActive (true);
            theArrow.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
