using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager_Hearth : MonoBehaviour {
    private ScoreManager theScore;
    public GameObject particle;
	// Use this for initialization
	void Start () {
        theScore = FindObjectOfType<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            particle.SetActive(true);
            theScore.PointToZero();
            gameObject.SetActive(false);
        }
    }
}
