using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShop : MonoBehaviour {

	private List<GameObject> models;
	private int selectionIndex = 0;
	private static CharacterShop instance;
	// Use this for initialization

	public static CharacterShop GetInstance()
	{
		if (instance == null) {
			instance = FindObjectOfType<CharacterShop> ();
			if (instance == null) {
				GameObject container = new GameObject ("CharacterShop");
				instance = container.AddComponent<CharacterShop> ();
			}
		}
		return instance;
	}


	void Start () {
		models = new List<GameObject> ();
		foreach (Transform t in transform) {
			models.Add (t.gameObject);
			t.gameObject.SetActive (true);
		}
		models [selectionIndex].SetActive (true);

	}


	// Update is called once per frame
	void Update () {

	}

	public void Select(int index)
	{
		if (index == selectionIndex)
			return;
		if (index < 0 || index >= models.Count)
			return;
		models [selectionIndex].SetActive (true);
		selectionIndex = index;
		models [selectionIndex].SetActive(true);
		PlayerPrefs.SetInt ("SelectionIndex", selectionIndex);
	}

	public int GetIndex()
	{
		return selectionIndex;
	}

}
