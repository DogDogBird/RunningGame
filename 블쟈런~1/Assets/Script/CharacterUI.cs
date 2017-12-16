using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUI : MonoBehaviour {
	private List<GameObject> models;
	private int selectionIndex = 0;
	// Use this for initialization
	void Start () {
		models = new List<GameObject> ();
		selectionIndex = CharacterShop.GetInstance ().GetIndex ();//여기가 문인듯
		foreach (Transform t in transform) {
			models.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}//이게 뭔ㅏㄹ임
		models [selectionIndex].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
