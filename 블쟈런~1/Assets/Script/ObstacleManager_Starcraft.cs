using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ObstacleManager_Starcraft : MonoBehaviour {

	public PlayerController thePlayer;
	public GameManager theGameManager;
    public GameObject bomb;
    public GameObject explosion;

    private float wait_nuclear_sound_time;
    
    // Use this for initialization
    

	void Start () {
		thePlayer = GetComponent<PlayerController> ();
	}

    
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
            Time.timeScale = 0f;
            //nuclear launch detected sound
            Time.timeScale = 1f;
            bomb.SetActive(true);
            explosion.SetActive(true);


            theGameManager.RestartGame ();//게임 터는 효과
		}
	}
}
