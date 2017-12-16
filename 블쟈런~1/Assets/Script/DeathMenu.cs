using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour {
	
    public Text goldAmount;

    public float currentScore;
    public float currentGold;

    public void Awake()
    {
        currentScore = ScoreManager.GetInstance().GetScore();
        currentGold = DataController.GetInstance().GetGold();
    }
    public void Start()
    {
		Time.timeScale = 1f;
        CalculateGold();
    }
    public void RestartGame()
    {
		Time.timeScale = 1f;
        FindObjectOfType<GameManager>().Reset();
    }

    public void QuitToMain()
    {
		Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void CalculateGold()
    {
        currentGold = (int)(Mathf.Pow(currentScore,(float)1.2) * 0.01);
        goldAmount.text = "X " + currentGold;
        DataController.GetInstance().AddGold((int)currentGold);
    }
}
