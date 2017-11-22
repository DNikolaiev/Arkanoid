using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public int health=3;
	public bool exictBall=true;
	public Text healthText;
	public Text gameOverText;
	public int score;
	public Text scoreText;

	public static GameManager instance=null;
	void Awake()
	{
		if (instance == null)
		{
			instance=this;
		} 
		else  if (instance!=this)
		{
			Destroy (gameObject);
		}
	}

	void Start()
	{
		Time.timeScale = 1;

	}


	// Update is called once per frame
	void Update () {
	
		healthText.text = "Health: " + health;
		scoreText.text = "Score: " + score;
		
		




	}

    public void CheckForWin()
    {
        if (score == (40 - SpawnManager.instance.count))
            Win();
        else return;
    }

	public void LoseLife()
	{
		health--;
		CheckIfGameOver ();
	}

	public void CheckIfGameOver()
	{
		if (health == 0)
			GameOver ();
	}

	public void GameOver()
	{
		Time.timeScale = 0;
		ButtonManager.instance.Activate (true);
		gameOverText.text = "Game Over!\n\nYour Score: " + score;
	}

	public void Win()
	{
        Time.timeScale = 0;
        ButtonManager.instance.Activate(true);
       
        gameOverText.text = "You have won!\nCongrats\nYour Score: "+ score;	

	}

}
