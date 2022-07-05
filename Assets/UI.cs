using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour
{

	int score = 0;
	GameObject scoreText;
	//GameObject gameOverText;

	public void AddScore()
	{
		this.score += 10;
	}
	public void GameOver()
	{
		//this.gameOverText.GetComponent<Text>().text = "Game Over";
	}

	void Start()
	{
		this.scoreText = GameObject.Find("Score");
		//this.gameOverText = GameObject.Find("GameOver");
	}

	void Update()
	{
		scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
	}
}