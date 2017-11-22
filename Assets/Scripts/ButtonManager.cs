using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class ButtonManager : MonoBehaviour {

	public Canvas gameOver;
	public float sliderValue=10f;

	public static ButtonManager instance=null;
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
		Activate (false);


	}

	public void Exit()
	{
	
		Application.Quit ();
	}


	


	public void Activate (bool state)
	{
		gameOver.enabled = state;
	}

	public void LaunchGame()
	{

		Application.LoadLevel (Application.loadedLevel);

	}


}


